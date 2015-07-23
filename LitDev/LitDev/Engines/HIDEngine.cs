//The following Copyright applies to Box2D and files in its namespace.

//Copyright (c) 2006-2007 Erin Catto http://www.gphysics.com

//This software is provided 'as-is', without any express or implied
//warranty. In no event will the authors be held liable for any damages
//arising from the use of this software.

//Permission is granted to anyone to use this software for any purpose,
//including commercial applications, and to alter it and redistribute it
//freely, subject to the following restrictions:

//1. The origin of this software must not be misrepresented; you must not
//claim that you wrote the original software. If you use this software
//in a product, an acknowledgment in the product documentation would be
//appreciated but is not required.
//2. Altered source versions must be plainly marked as such, and must not be
//misrepresented as being the original software.
//3. This notice may not be removed or altered from any source distribution.

//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

//Modified from http://www.developerfusion.com/article/84338/making-usb-c-friendly/

using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Microsoft.SmallBasic.Library;

namespace LitDev
{
    #region Custom exception
    public class HIDDeviceException : ApplicationException
    {
        public HIDDeviceException(string strMessage) : base(strMessage) { }

        public static HIDDeviceException GenerateWithWinError(string strMessage)
        {
            return new HIDDeviceException(string.Format("Msg:{0} WinEr:{1:X8}", strMessage, Marshal.GetLastWin32Error()));
        }
    }
    #endregion
    public abstract class HIDDevice : Win32Usb, IDisposable
    {
        #region Privates variables
        /// <summary>Filestream we can use to read/write from</summary>
        private FileStream m_oFile;
        /// <summary>Length of input report : device gives us this</summary>
        private int m_nInputReportLength;
        /// <summary>Length if output report : device gives us this</summary>
        private int m_nOutputReportLength;
        /// <summary>Handle to the device</summary>
        private IntPtr m_hHandle;
        #endregion

        #region IDisposable Members
        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Disposer called by both dispose and finalise
        /// </summary>
        /// <param name="bDisposing">True if disposing</param>
        protected virtual void Dispose(bool bDisposing)
        {
            if (bDisposing)	// if we are disposing, need to close the managed resources
            {
                if (m_oFile != null)
                {
                    m_oFile.Close();
                    m_oFile = null;
                }
            }
            if (m_hHandle != IntPtr.Zero)	// Dispose and finalize, get rid of unmanaged resources
            {
                CloseHandle(m_hHandle);
            }
        }
        #endregion

        #region Privates/protected
        /// <summary>
        /// Initialises the device
        /// </summary>
        /// <param name="strPath">Path to the device</param>
        private void Initialise(string strPath)
        {
            // Create the file from the device path
            m_hHandle = CreateFile(strPath, GENERIC_READ | GENERIC_WRITE, 0, IntPtr.Zero, OPEN_EXISTING, FILE_FLAG_OVERLAPPED, IntPtr.Zero);
            if (m_hHandle != InvalidHandleValue)	// if the open worked...
            {
                IntPtr lpData;
                if (HidD_GetPreparsedData(m_hHandle, out lpData))	// get windows to read the device data into an internal buffer
                {
                    try
                    {
                        HidCaps oCaps;
                        HidP_GetCaps(lpData, out oCaps);	// extract the device capabilities from the internal buffer
                        m_nInputReportLength = oCaps.InputReportByteLength;	// get the input...
                        m_nOutputReportLength = oCaps.OutputReportByteLength;	// ... and output report lengths
                        //m_oFile = new FileStream(m_hHandle, FileAccess.Read | FileAccess.Write, true, m_nInputReportLength, true);	// wrap the file handle in a .Net file stream
                        SafeFileHandle safeFileHandle = new SafeFileHandle(m_hHandle, true);
                        m_oFile = new FileStream(safeFileHandle, FileAccess.Read | FileAccess.Write, m_nInputReportLength, true);
                        BeginAsyncRead();	// kick off the first asynchronous read
                    }
                    finally
                    {
                        HidD_FreePreparsedData(ref lpData);	// before we quit the funtion, we must free the internal buffer reserved in GetPreparsedData
                    }
                }
                else	// GetPreparsedData failed? Chuck an exception
                {
                    throw HIDDeviceException.GenerateWithWinError("GetPreparsedData failed");
                }
            }
            else	// File open failed? Chuck an exception
            {
                m_hHandle = IntPtr.Zero;
                throw HIDDeviceException.GenerateWithWinError("Failed to create device file");
            }
        }
        /// <summary>
        /// Kicks off an asynchronous read which completes when data is read or when the device
        /// is disconnected. Uses a callback.
        /// </summary>
        private void BeginAsyncRead()
        {
            byte[] arrInputReport = new byte[m_nInputReportLength];
            // put the buff we used to receive the stuff as the async state then we can get at it when the read completes
            m_oFile.BeginRead(arrInputReport, 0, m_nInputReportLength, new AsyncCallback(ReadCompleted), arrInputReport);
        }
        /// <summary>
        /// Callback for above. Care with this as it will be called on the background thread from the async read
        /// </summary>
        /// <param name="iResult">Async result parameter</param>
        protected void ReadCompleted(IAsyncResult iResult)
        {
            byte[] arrBuff = (byte[])iResult.AsyncState;	// retrieve the read buffer
            try
            {
                m_oFile.EndRead(iResult);	// call end read : this throws any exceptions that happened during the read
                try
                {
                    InputReport oInRep = CreateInputReport();	// Create the input report for the device
                    oInRep.SetData(arrBuff);	// and set the data portion - this processes the data received into a more easily understood format depending upon the report type
                    HandleDataReceived(oInRep);	// pass the new input report on to the higher level handler
                }
                finally
                {
                    BeginAsyncRead();	// when all that is done, kick off another read for the next report
                }
            }
            catch (IOException ex)	// if we got an IO exception, the device was removed
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                HandleDeviceRemoved();
                if (OnDeviceRemoved != null)
                {
                    OnDeviceRemoved(this, new EventArgs());
                }
                Dispose();
            }
        }
        /// <summary>
        /// Write an output report to the device.
        /// </summary>
        /// <param name="oOutRep">Output report to write</param>
        protected void Write(OutputReport oOutRep)
        {
            try
            {
                m_oFile.Write(oOutRep.Buffer, 0, oOutRep.BufferLength);
            }
            catch (IOException ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                // The device was removed!
                throw new HIDDeviceException("Device was removed");
            }
        }
        /// <summary>
        /// virtual handler for any action to be taken when data is received. Override to use.
        /// </summary>
        /// <param name="oInRep">The input report that was received</param>
        protected virtual void HandleDataReceived(InputReport oInRep)
        {
        }
        /// <summary>
        /// Virtual handler for any action to be taken when a device is removed. Override to use.
        /// </summary>
        protected virtual void HandleDeviceRemoved()
        {
        }
        /// <summary>
        /// Helper method to return the device path given a DeviceInterfaceData structure and an InfoSet handle.
        /// Used in 'FindDevice' so check that method out to see how to get an InfoSet handle and a DeviceInterfaceData.
        /// </summary>
        /// <param name="hInfoSet">Handle to the InfoSet</param>
        /// <param name="oInterface">DeviceInterfaceData structure</param>
        /// <returns>The device path or null if there was some problem</returns>
        private static string GetDevicePath(IntPtr hInfoSet, ref DeviceInterfaceData oInterface)
        {
            uint nRequiredSize = 0;
            DeviceInfoData da = new DeviceInfoData();
            da.Size = (uint)Marshal.SizeOf(da);
            // Get the device interface details
            if (!SetupDiGetDeviceInterfaceDetail(hInfoSet, ref oInterface, IntPtr.Zero, 0, ref nRequiredSize, ref da))
            {
                DeviceInterfaceDetailData oDetail = new DeviceInterfaceDetailData();
                oDetail.Size = (IntPtr.Size == 4) ? 5 : 8;	// hardcoded to 5! Sorry, but this works and trying more future proof versions by setting the size to the struct sizeof failed miserably. If you manage to sort it, mail me! Thx

                if (SetupDiGetDeviceInterfaceDetail(hInfoSet, ref oInterface, ref oDetail, nRequiredSize, ref nRequiredSize, ref da))
                {
                    return oDetail.DevicePath;
                }
            }
            return null;
        }
        private static string GetDeviceName()
        {
            Guid gHid;
            HidD_GetHidGuid(out gHid);	// next, get the GUID from Windows that it uses to represent the HID USB interface
            IntPtr hInfoSet = SetupDiGetClassDevs(ref gHid, null, IntPtr.Zero, DIGCF_DEVICEINTERFACE | DIGCF_PRESENT);	// this gets a list of all HID devices currently connected to the computer (InfoSet)

            try
            {
                uint SPDRP_DEVICEDESC = 0x00000000;
                uint SPDRP_DRIVER = 0x00000009;
                int BUFFER_SIZE = 256;
                bool Success = true;
                int i = 0;
                while (Success)
                {
                    // create a Device Interface Data structure
                    DeviceInterfaceData oInterface = new DeviceInterfaceData();	// build up a device interface data block
                    oInterface.Size = Marshal.SizeOf(oInterface);

                    // start the enumeration
                    Success = SetupDiEnumDeviceInterfaces(hInfoSet, IntPtr.Zero, ref gHid, (uint)i, ref oInterface);
                    if (Success)
                    {
                        // build a Device Interface Detail Data structure
                        DeviceInterfaceDetailData oDetail = new DeviceInterfaceDetailData();
                        oDetail.Size = (IntPtr.Size == 4) ? 5 : 8;	// hardcoded to 5! Sorry, but this works and trying more future proof versions by setting the size to the struct sizeof failed miserably. If you manage to sort it, mail me! Thx

                        DeviceInfoData da = new DeviceInfoData();
                        da.Size = (uint)Marshal.SizeOf(da);

                        // now we can get some more detailed information
                        uint nRequiredSize = 0;
                        int nBytes = BUFFER_SIZE;
                        //hInfoSet, ref oInterface, ref oDetail, nRequiredSize, ref nRequiredSize, IntPtr.Zero;
                        if (SetupDiGetDeviceInterfaceDetail(hInfoSet, ref oInterface, ref oDetail, (uint)nBytes, ref nRequiredSize, ref da))
                        {
                            // get the Device Description and DriverKeyName
                            uint RequiredSize;
                            uint RegType;
                            byte[] ptrBuf = new byte[BUFFER_SIZE];

                            if (SetupDiGetDeviceRegistryProperty(hInfoSet, ref oInterface, SPDRP_DEVICEDESC, out RegType, ptrBuf, (uint)BUFFER_SIZE, out RequiredSize))
                            {
                                string ControllerDeviceDesc = System.Text.Encoding.UTF8.GetString(ptrBuf);// Marshal.PtrToStringAuto(ptrBuf);
                            }
                            if (SetupDiGetDeviceRegistryProperty(hInfoSet, ref oInterface, SPDRP_DRIVER, out RegType, ptrBuf, (uint)BUFFER_SIZE, out RequiredSize))
                            {
                                string ControllerDriverKeyName = System.Text.Encoding.UTF8.GetString(ptrBuf);
                            }
                        }
                    }
                    i++;
                }
            }
            finally
            {
                // Before we go, we have to free up the InfoSet memory reserved by SetupDiGetClassDevs
                SetupDiDestroyDeviceInfoList(hInfoSet);
            }
            return "";
        }
        #endregion

        #region Public static
        /// <summary>
        /// Finds a device given its PID and VID
        /// </summary>
        /// <param name="nVid">Vendor id for device (VID)</param>
        /// <param name="nPid">Product id for device (PID)</param>
        /// <param name="oType">Type of device class to create</param>
        /// <returns>A new device class of the given type or null</returns>
        public static HIDDevice FindDevice(int nVid, int nPid, Type oType)
        {
            //GetDeviceName();

            string strPath = string.Empty;
            string strSearch = string.Format("vid_{0:x4}&pid_{1:x4}", nVid, nPid); // first, build the path search string
            Guid gHid;
            HidD_GetHidGuid(out gHid);	// next, get the GUID from Windows that it uses to represent the HID USB interface
            IntPtr hInfoSet = SetupDiGetClassDevs(ref gHid, null, IntPtr.Zero, DIGCF_DEVICEINTERFACE | DIGCF_PRESENT);	// this gets a list of all HID devices currently connected to the computer (InfoSet)
            try
            {
                DeviceInterfaceData oInterface = new DeviceInterfaceData();	// build up a device interface data block
                oInterface.Size = Marshal.SizeOf(oInterface);
                // Now iterate through the InfoSet memory block assigned within Windows in the call to SetupDiGetClassDevs
                // to get device details for each device connected
                int nIndex = 0;
                while (SetupDiEnumDeviceInterfaces(hInfoSet, IntPtr.Zero, ref gHid, (uint)nIndex, ref oInterface))	// this gets the device interface information for a device at index 'nIndex' in the memory block
                {
                    string strDevicePath = GetDevicePath(hInfoSet, ref oInterface);	// get the device path (see helper method 'GetDevicePath')
                    if (strDevicePath.IndexOf(strSearch) >= 0)	// do a string search, if we find the VID/PID string then we found our device!
                    {
                        HIDDevice oNewDevice = (HIDDevice)Activator.CreateInstance(oType);	// create an instance of the class for this device
                        oNewDevice.Initialise(strDevicePath);	// initialise it with the device path
                        return oNewDevice;	// and return it
                    }
                    nIndex++;	// if we get here, we didn't find our device. So move on to the next one.
                }
            }
            finally
            {
                // Before we go, we have to free up the InfoSet memory reserved by SetupDiGetClassDevs
                SetupDiDestroyDeviceInfoList(hInfoSet);
            }
            return null;	// oops, didn't find our device
        }
        #endregion

        #region Publics
        /// <summary>
        /// Event handler called when device has been removed
        /// </summary>
        public event EventHandler OnDeviceRemoved;
        /// <summary>
        /// Accessor for output report length
        /// </summary>
        public int OutputReportLength
        {
            get
            {
                return m_nOutputReportLength;
            }
        }
        /// <summary>
        /// Accessor for input report length
        /// </summary>
        public int InputReportLength
        {
            get
            {
                return m_nInputReportLength;
            }
        }
        /// <summary>
        /// Virtual method to create an input report for this device. Override to use.
        /// </summary>
        /// <returns>A shiny new input report</returns>
        public virtual InputReport CreateInputReport()
        {
            return null;
        }
        #endregion
    }

    public abstract class Report
    {
        #region Member variables
        /// <summary>Buffer for raw report bytes</summary>
        private byte[] m_arrBuffer;
        /// <summary>Length of the report</summary>
        private int m_nLength;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="oDev">Constructing device</param>
        public Report(HIDDevice oDev)
        {
            // Do nothing
        }

        /// <summary>
        /// Sets the raw byte array.
        /// </summary>
        /// <param name="arrBytes">Raw report bytes</param>
        protected void SetBuffer(byte[] arrBytes)
        {
            m_arrBuffer = arrBytes;
            m_nLength = m_arrBuffer.Length;
        }

        /// <summary>
        /// Accessor for the raw byte buffer
        /// </summary>
        public byte[] Buffer
        {
            get
            {
                return m_arrBuffer;
            }
        }
        /// <summary>
        /// Accessor for the buffer length
        /// </summary>
        public int BufferLength
        {
            get
            {
                return m_nLength;
            }
        }
    }
    public abstract class OutputReport : Report
    {
        /// <summary>
        /// Construction. Setup the buffer with the correct output report length dictated by the device
        /// </summary>
        /// <param name="oDev">Creating device</param>
        public OutputReport(HIDDevice oDev)
            : base(oDev)
        {
            SetBuffer(new byte[oDev.OutputReportLength]);
        }
    }
    public abstract class InputReport : Report
    {
        /// <summary>
        /// Construction. Do nothing
        /// </summary>
        /// <param name="oDev">Creating device</param>
        public InputReport(HIDDevice oDev)
            : base(oDev)
        {
        }
        /// <summary>
        /// Call this to set the buffer given a raw input report. Calls an overridable method to
        /// should automatically parse the bytes into meaningul structures.
        /// </summary>
        /// <param name="arrData">Raw input report.</param>
        public void SetData(byte[] arrData)
        {
            SetBuffer(arrData);
            ProcessData();
        }
        /// <summary>
        /// Override this to process the input report into something useful
        /// </summary>
        public abstract void ProcessData();
    }
    
    public class Win32Usb
    {
        #region Structures
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        protected struct Overlapped
        {
            public uint Internal;
            public uint InternalHigh;
            public uint Offset;
            public uint OffsetHigh;
            public IntPtr Event;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        protected struct DeviceInterfaceData
        {
            public int Size;
            public Guid InterfaceClassGuid;
            public int Flags;
            public IntPtr Reserved;
            //public int Size;
            //public Guid InterfaceClassGuid;
            //public int Flags;
            //public int Reserved;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        protected struct DeviceInfoData
        {
            public uint Size;
            public Guid InterfaceClassGuid;
            public uint Flags;
            public IntPtr Reserved;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        protected struct HidCaps
        {
            public short Usage;
            public short UsagePage;
            public short InputReportByteLength;
            public short OutputReportByteLength;
            public short FeatureReportByteLength;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
            public short[] Reserved;
            public short NumberLinkCollectionNodes;
            public short NumberInputButtonCaps;
            public short NumberInputValueCaps;
            public short NumberInputDataIndices;
            public short NumberOutputButtonCaps;
            public short NumberOutputValueCaps;
            public short NumberOutputDataIndices;
            public short NumberFeatureButtonCaps;
            public short NumberFeatureValueCaps;
            public short NumberFeatureDataIndices;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DeviceInterfaceDetailData
        {
            public int Size;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string DevicePath;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public class DeviceBroadcastInterface
        {
            public int Size;
            public int DeviceType;
            public int Reserved;
            public Guid ClassGuid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Name;
        }
        #endregion

        #region Constants
        /// <summary>Windows message sent when a device is inserted or removed</summary>
        public const int WM_DEVICECHANGE = 0x0219;
        /// <summary>WParam for above : A device was inserted</summary>
        public const int DEVICE_ARRIVAL = 0x8000;
        /// <summary>WParam for above : A device was removed</summary>
        public const int DEVICE_REMOVECOMPLETE = 0x8004;
        /// <summary>Used in SetupDiClassDevs to get devices present in the system</summary>
        protected const int DIGCF_PRESENT = 0x02;
        /// <summary>Used in SetupDiClassDevs to get device interface details</summary>
        protected const int DIGCF_DEVICEINTERFACE = 0x10;
        /// <summary>Used when registering for device insert/remove messages : specifies the type of device</summary>
        protected const int DEVTYP_DEVICEINTERFACE = 0x05;
        /// <summary>Used when registering for device insert/remove messages : we're giving the API call a window handle</summary>
        protected const int DEVICE_NOTIFY_WINDOW_HANDLE = 0;
        /// <summary>Purges Win32 transmit buffer by aborting the current transmission.</summary>
        protected const uint PURGE_TXABORT = 0x01;
        /// <summary>Purges Win32 receive buffer by aborting the current receive.</summary>
        protected const uint PURGE_RXABORT = 0x02;
        /// <summary>Purges Win32 transmit buffer by clearing it.</summary>
        protected const uint PURGE_TXCLEAR = 0x04;
        /// <summary>Purges Win32 receive buffer by clearing it.</summary>
        protected const uint PURGE_RXCLEAR = 0x08;
        /// <summary>CreateFile : Open file for read</summary>
        protected const uint GENERIC_READ = 0x80000000;
        /// <summary>CreateFile : Open file for write</summary>
        protected const uint GENERIC_WRITE = 0x40000000;
        /// <summary>CreateFile : Open handle for overlapped operations</summary>
        protected const uint FILE_FLAG_OVERLAPPED = 0x40000000;
        /// <summary>CreateFile : Resource to be "created" must exist</summary>
        protected const uint OPEN_EXISTING = 3;
        /// <summary>ReadFile/WriteFile : Overlapped operation is incomplete.</summary>
        protected const uint ERROR_IO_PENDING = 997;
        /// <summary>Infinite timeout</summary>
        protected const uint INFINITE = 0xFFFFFFFF;
        /// <summary>Simple representation of a null handle : a closed stream will get this handle. Note it is public for comparison by higher level classes.</summary>
        public static IntPtr NullHandle = IntPtr.Zero;
        /// <summary>Simple representation of the handle returned when CreateFile fails.</summary>
        protected static IntPtr InvalidHandleValue = new IntPtr(-1);
        #endregion

        #region P/Invoke
        /// <summary>
        /// Gets the GUID that Windows uses to represent HID class devices
        /// </summary>
        /// <param name="gHid">An out parameter to take the Guid</param>
        [DllImport("hid.dll", SetLastError = true)]
        protected static extern void HidD_GetHidGuid(out Guid gHid);
        /// <summary>
        /// Allocates an InfoSet memory block within Windows that contains details of devices.
        /// </summary>
        /// <param name="gClass">Class guid (e.g. HID guid)</param>
        /// <param name="strEnumerator">Not used</param>
        /// <param name="hParent">Not used</param>
        /// <param name="nFlags">Type of device details required (DIGCF_ constants)</param>
        /// <returns>A reference to the InfoSet</returns>
        [DllImport("setupapi.dll", SetLastError = true)]
        protected static extern IntPtr SetupDiGetClassDevs(ref Guid gClass, [MarshalAs(UnmanagedType.LPStr)] string strEnumerator, IntPtr hParent, uint nFlags);
        /// <summary>
        /// Frees InfoSet allocated in call to above.
        /// </summary>
        /// <param name="lpInfoSet">Reference to InfoSet</param>
        /// <returns>true if successful</returns>
        [DllImport("setupapi.dll", SetLastError = true)]
        protected static extern int SetupDiDestroyDeviceInfoList(IntPtr lpInfoSet);
        /// <summary>
        /// Gets the DeviceInterfaceData for a device from an InfoSet.
        /// </summary>
        /// <param name="lpDeviceInfoSet">InfoSet to access</param>
        /// <param name="pDeviceInfoData">Not used</param>
        /// <param name="gClass">Device class guid</param>
        /// <param name="nIndex">Index into InfoSet for device</param>
        /// <param name="oInterfaceData">DeviceInterfaceData to fill with data</param>
        /// <returns>True if successful, false if not (e.g. when index is passed end of InfoSet)</returns>
        [DllImport("setupapi.dll", SetLastError = true)]
        protected static extern bool SetupDiEnumDeviceInterfaces(IntPtr lpDeviceInfoSet, IntPtr pDeviceInfoData, ref Guid gClass, uint nIndex, ref DeviceInterfaceData oInterfaceData);
        /// <summary>
        /// SetupDiGetDeviceInterfaceDetail - two of these, overloaded because they are used together in slightly different
        /// ways and the parameters have different meanings.
        /// Gets the interface detail from a DeviceInterfaceData. This is pretty much the device path.
        /// You call this twice, once to get the size of the struct you need to send (nDeviceInterfaceDetailDataSize=0)
        /// and once again when you've allocated the required space.
        /// </summary>
        /// <param name="lpDeviceInfoSet">InfoSet to access</param>
        /// <param name="oInterfaceData">DeviceInterfaceData to use</param>
        /// <param name="lpDeviceInterfaceDetailData">DeviceInterfaceDetailData to fill with data</param>
        /// <param name="nDeviceInterfaceDetailDataSize">The size of the above</param>
        /// <param name="nRequiredSize">The required size of the above when above is set as zero</param>
        /// <param name="lpDeviceInfoData">Not used</param>
        /// <returns></returns>
        [DllImport("setupapi.dll", SetLastError = true)]
        protected static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr lpDeviceInfoSet, ref DeviceInterfaceData oInterfaceData, IntPtr lpDeviceInterfaceDetailData, uint nDeviceInterfaceDetailDataSize, ref uint nRequiredSize, ref DeviceInfoData lpDeviceInfoData);
        [DllImport("setupapi.dll", SetLastError = true)]
        protected static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr lpDeviceInfoSet, ref DeviceInterfaceData oInterfaceData, ref DeviceInterfaceDetailData oDetailData, uint nDeviceInterfaceDetailDataSize, ref uint nRequiredSize, ref DeviceInfoData lpDeviceInfoData);
        /// <summary>
        /// Registers a window for device insert/remove messages
        /// </summary>
        /// <param name="hwnd">Handle to the window that will receive the messages</param>
        /// <param name="oInterface">DeviceBroadcastInterrface structure</param>
        /// <param name="nFlags">set to DEVICE_NOTIFY_WINDOW_HANDLE</param>
        /// <returns>A handle used when unregistering</returns>
        [DllImport("user32.dll", SetLastError = true)]
        protected static extern IntPtr RegisterDeviceNotification(IntPtr hwnd, DeviceBroadcastInterface oInterface, uint nFlags);
        /// <summary>
        /// Unregister from above.
        /// </summary>
        /// <param name="hHandle">Handle returned in call to RegisterDeviceNotification</param>
        /// <returns>True if success</returns>
        [DllImport("user32.dll", SetLastError = true)]
        protected static extern bool UnregisterDeviceNotification(IntPtr hHandle);
        /// <summary>
        /// Gets details from an open device. Reserves a block of memory which must be freed.
        /// </summary>
        /// <param name="hFile">Device file handle</param>
        /// <param name="lpData">Reference to the preparsed data block</param>
        /// <returns></returns>
        [DllImport("hid.dll", SetLastError = true)]
        protected static extern Boolean HidD_GetPreparsedData(IntPtr hFile, out IntPtr lpData);
        /// <summary>
        /// Frees the memory block reserved above.
        /// </summary>
        /// <param name="pData">Reference to preparsed data returned in call to GetPreparsedData</param>
        /// <returns></returns>
        [DllImport("hid.dll", SetLastError = true)]
        protected static extern Boolean HidD_FreePreparsedData(ref IntPtr pData);
        /// <summary>
        /// Gets a device's capabilities from the preparsed data.
        /// </summary>
        /// <param name="lpData">Preparsed data reference</param>
        /// <param name="oCaps">HidCaps structure to receive the capabilities</param>
        /// <returns>True if successful</returns>
        [DllImport("hid.dll", SetLastError = true)]
        protected static extern int HidP_GetCaps(IntPtr lpData, out HidCaps oCaps);
        /// <summary>
        /// Creates/opens a file, serial port, USB device... etc
        /// </summary>
        /// <param name="strName">Path to object to open</param>
        /// <param name="nAccess">Access mode. e.g. Read, write</param>
        /// <param name="nShareMode">Sharing mode</param>
        /// <param name="lpSecurity">Security details (can be null)</param>
        /// <param name="nCreationFlags">Specifies if the file is created or opened</param>
        /// <param name="nAttributes">Any extra attributes? e.g. open overlapped</param>
        /// <param name="lpTemplate">Not used</param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        protected static extern IntPtr CreateFile([MarshalAs(UnmanagedType.LPStr)] string strName, uint nAccess, uint nShareMode, IntPtr lpSecurity, uint nCreationFlags, uint nAttributes, IntPtr lpTemplate);
        /// <summary>
        /// Closes a window handle. File handles, event handles, mutex handles... etc
        /// </summary>
        /// <param name="hFile">Handle to close</param>
        /// <returns>True if successful.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        protected static extern int CloseHandle(IntPtr hFile);

        [DllImport("setupapi.dll", SetLastError = true)]
        protected static extern bool SetupDiGetDeviceRegistryProperty(
            IntPtr DeviceInfoSet,
            ref DeviceInterfaceData DeviceInfoData,
            uint Property,
            out UInt32 PropertyRegDataType,
            byte[] PropertyBuffer, // the difference between this signature and the one above.
            uint PropertyBufferSize,
            out UInt32 RequiredSize
            );
        #endregion

        #region Public methods
        /// <summary>
        /// Registers a window to receive windows messages when a device is inserted/removed. Need to call this
        /// from a form when its handle has been created, not in the form constructor. Use form's OnHandleCreated override.
        /// </summary>
        /// <param name="hWnd">Handle to window that will receive messages</param>
        /// <param name="gClass">Class of devices to get messages for</param>
        /// <returns>A handle used when unregistering</returns>
        public static IntPtr RegisterForUsbEvents(IntPtr hWnd, Guid gClass)
        {
            DeviceBroadcastInterface oInterfaceIn = new DeviceBroadcastInterface();
            oInterfaceIn.Size = Marshal.SizeOf(oInterfaceIn);
            oInterfaceIn.ClassGuid = gClass;
            oInterfaceIn.DeviceType = DEVTYP_DEVICEINTERFACE;
            oInterfaceIn.Reserved = 0;
            return RegisterDeviceNotification(hWnd, oInterfaceIn, DEVICE_NOTIFY_WINDOW_HANDLE);
        }
        /// <summary>
        /// Unregisters notifications. Can be used in form dispose
        /// </summary>
        /// <param name="hHandle">Handle returned from RegisterForUSBEvents</param>
        /// <returns>True if successful</returns>
        public static bool UnregisterForUsbEvents(IntPtr hHandle)
        {
            return UnregisterDeviceNotification(hHandle);
        }
        /// <summary>
        /// Helper to get the HID guid.
        /// </summary>
        public static Guid HIDGuid
        {
            get
            {
                Guid gHid;
                HidD_GetHidGuid(out gHid);
                return gHid;
            }
        }
        #endregion
    }
}
