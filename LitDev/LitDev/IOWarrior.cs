//#define SVB   
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2020> litdev@hotmail.co.uk
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

using LitDev.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace LitDev
{
    class IOWDevice
    {
        public uint id = 0;
        public string name = "";
        public IntPtr handle = IntPtr.Zero;
        public uint pid = 0;
        public StringBuilder sn = new StringBuilder();
        public uint version = 0;
        public uint reportSize = 0;
        public uint specialReportSize = 0;

        public IOWDevice(uint id)
        {
            this.id = id;
            this.handle = Functions.IowKitGetDeviceHandle(id);
            this.pid = Functions.IowKitGetProductId(handle);
            Functions.IowKitSetTimeout(handle, LDIOWarrior.timeout);
            Functions.IowKitSetWriteTimeout(handle, LDIOWarrior.timeout);
            Functions.IowKitGetSerialNumber(handle, sn);
            version = Functions.IowKitGetRevision(handle);
            switch (this.pid)
            {
                case Defines.IOWKIT_PID_IOW40:
                    this.name = "IO-Warrior40";
                    this.reportSize = Defines.IOWKIT40_IO_REPORT_SIZE;
                    this.specialReportSize = Defines.IOWKIT_SPECIAL_REPORT_SIZE;
                    break;
                case Defines.IOWKIT_PID_IOW24:
                    this.name = "IO-Warrior24";
                    this.reportSize = Defines.IOWKIT24_IO_REPORT_SIZE;
                    this.specialReportSize = Defines.IOWKIT_SPECIAL_REPORT_SIZE;
                    break;
                case Defines.IOWKIT_PID_IOW56:
                    this.name = "IO-Warrior56";
                    this.reportSize = Defines.IOWKIT56_IO_REPORT_SIZE;
                    this.specialReportSize = Defines.IOWKIT56_SPECIAL_REPORT_SIZE;
                    break;
            }
        }

        public uint Read(uint channel, byte[] buffer, bool bBlocking, uint length)
        {
            if (bBlocking)
            {
                return Functions.IowKitRead(handle, channel, buffer, length);
            }
            else
            {
                return Functions.IowKitReadNonBlocking(handle, channel, buffer, length);
            }
        }

        public uint Write(uint channel, byte[] buffer, uint length)
        {
            return Functions.IowKitWrite(handle, channel, buffer, length);
        }
    }

    /// <summary>
    /// Access IO-Warrior devices.
    /// See http://www.codemercs.com/io-warrior/?L=1
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDIOWarrior
    {
        public static uint timeout = 1000;

        private static List<IOWDevice> IOWDevices = new List<IOWDevice>();

        private static IOWDevice GetDevice(uint id)
        {
            foreach (IOWDevice i in IOWDevices)
            {
                if (i.id == id)
                {
                    return i;
                }
            }
            return null;
        }

        private static string AddDevice(uint id)
        {
            IOWDevice device = new IOWDevice(id);
            IOWDevices.Add(device);
            return device.name;
        }

        private static void RemoveDevice(uint id)
        {
            IOWDevice device = GetDevice(id);
            if (null == device) return;
            Functions.IowKitCloseDevice(device.handle);
            IOWDevices.Remove(device);
        }

        private static int LoadAll()
        {
            ExtractDll();
            Functions.IowKitOpenDevice();

            int count = (int)Functions.IowKitGetNumDevs();
            for (uint i = 0; i < count; i++)
            {
                AddDevice(i+1);
            }

            return count;
        }

        private static void RemoveAll()
        {
            foreach (IOWDevice i in IOWDevices)
            {
                Functions.IowKitCloseDevice(i.handle);
            }
            IOWDevices.Clear();
        }

        private static void ExtractDll()
        {
            try
            {
                string filename = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\iowkit.dll";
                if (!System.IO.File.Exists(filename))
                {
                    Byte[] dll = (IntPtr.Size == 8) ? global::LitDev.Properties.Resources.iowkit64 : global::LitDev.Properties.Resources.iowkit32;
                    using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                    {
                        fs.Write(dll, 0, dll.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Initialise IO-Warrior devices.
        /// </summary>
        /// <returns>The number of devices.</returns>
        public static Primitive Initialise()
        {
            try
            {
                return LoadAll();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Disconnect all IO-Warrior devices.
        /// </summary>
        public static void Detatch()
        {
            try
            {
                RemoveAll();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get the last system error message.
        /// "" for no error (probably only useful for detailed error analysis of underlying system calls).
        /// </summary>
        /// <returns>Last error number.</returns>
        public static Primitive LastError()
        {
            uint error = Functions.GetLastError();
            if (error == 0) return "";
            return new System.ComponentModel.Win32Exception((int)error).Message;
        }

        /// <summary>
        /// Read from the IO-Warrior device.
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <param name="channel">The channel to read (indexed from 0).</param>
        /// <param name="blocking">"True" (return after the state changes) or "False" (return with current state).</param>
        /// <param name="count">The number of bytes to read (if zero, then the ReportSize is used if channel is 0 or SpecialReportSize if channel is 1).
        /// See GetReportSize and GetSpecialReportSize.</param>
        /// <returns>An array of read bytes [0 to 255].</returns>
        public static Primitive Read(Primitive id, Primitive channel, Primitive blocking, Primitive count)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return "";
                uint length = (uint)(int)count;
                if (length == 0) length = (channel == 0) ? device.reportSize : device.specialReportSize;
                byte[] buffer = new byte[length];
                length = device.Read((uint)(int)channel, buffer, blocking, length);
                string result = "";
                for (int i = 0; i < length; i++)
                {
                    result += (i + 1).ToString() + "=" + (int)buffer[i] + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Write to the IO-Warrior device.
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <param name="channel">The channel to write to (indexed from 0).</param>
        /// <param name="data">An array of bytes to send [0 to 255].
        /// The array size should be ReportSize for channel 0 and SpecialReportSize for channel 1.
        /// See GetReportSize and GetSpecialReportSize.</param>
        /// <returns>The number of bytes successfully written.</returns>
        public static Primitive Write(Primitive id, Primitive channel, Primitive data)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return 0;
                int length = SBArray.GetItemCount(data);
                byte[] buffer = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    buffer[i] = (byte)data[i + 1];
                }
                return (int)device.Write((uint)(int)channel, buffer, (uint)length);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Get the report size.
        /// Number of bytes in a Read/Write.
        /// This the report size for channel 0.
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <returns>The report size or 0.</returns>
        public static Primitive GetReportSize(Primitive id)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return 0;
                return (int)device.reportSize;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Get the special report size.
        /// Number of bytes in a special Read/Write.
        /// This the report size for channel 1.
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <returns>The special report size or 0.</returns>
        public static Primitive GetSpecialReportSize(Primitive id)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return 0;
                return (int)device.specialReportSize;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Get the device name.
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <returns>The device name or "".</returns>
        public static Primitive GetName(Primitive id)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return "";
                return device.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Get the device PID.
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <returns>The device PID (hex) or 0.</returns>
        public static Primitive GetPID(Primitive id)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return 0;
                return Convert.ToString(device.pid, 16);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Get the device VID (Common to all IOWarrior types).
        /// </summary>
        /// <returns>The device VID (hex) or 0.</returns>
        public static Primitive GetVID()
        {
            try
            {
                return Convert.ToString(Defines.IOWKIT_VID, 16);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Get the device serial number.
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <returns>The device serial number or "".</returns>
        public static Primitive GetSerialNumber(Primitive id)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return "";
                return device.sn.ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Get the device firmware version.
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <returns>The device firmware version or 0.</returns>
        public static Primitive GetVersion(Primitive id)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return 0;
                return (int)device.version;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// The timeout for read and writes in ms.
        /// Default 1000.
        /// </summary>
        public static Primitive Timeout
        {
            get { return (int)timeout; }
            set
            {
                timeout = (uint)(int)value;
                foreach (IOWDevice i in IOWDevices)
                {
                    Functions.IowKitSetTimeout(i.handle, timeout);
                    Functions.IowKitSetWriteTimeout(i.handle, timeout);
                }
            }
        }

        /// <summary>
        /// Write text to the LCD (untested).
        /// </summary>
        /// <param name="id">The device number (indexed from 1).</param>
        /// <param name="text">The text to write.</param>
        public static void LCDWrite(Primitive id, Primitive text)
        {
            try
            {
                IOWDevice device = GetDevice((uint)(int)id);
                if (null == device) return;

                int length = GetSpecialReportSize(id);
                byte[] buffer = new byte[length];
                for (int i = 0; i < length; i++) buffer[i] = 0;

                buffer[0] = 4;
                buffer[1] = 1;
                device.Write(1, buffer, (uint)length);

                buffer[0] = 5;
                buffer[1] = 3;
                buffer[2] = 40;
                buffer[3] = 1;
                buffer[4] = 15;
                device.Write(1, buffer, (uint)length);

                buffer[0] = 5;
                buffer[1] = 1;
                buffer[2] = 15;
                device.Write(1, buffer, (uint)length);

                buffer[0] = 5;
                buffer[1] = 1;
                buffer[2] = 6;
                device.Write(1, buffer, (uint)length);

                string txt = (string)text;
                int nChars = txt.Length;
                buffer[0] = 5;
                int nCurr = 0;
                int nNow;
                while (nCurr < nChars)
                {
                    if (nCurr + 6 > nChars)
                        nNow = nChars - nCurr;
                    else
                        nNow = 6;
                    buffer[1] = (byte)(128 + nNow);
                    for (int i = 0; i < nNow; i++)
                    {
                        buffer[2 + i] = (byte)(txt.ToCharArray()[i]);
                    }
                    device.Write(1, buffer, (uint)length);
                    nCurr += 6;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }
}
