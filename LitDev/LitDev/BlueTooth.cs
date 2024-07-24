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

//http://32feet.codeplex.com/license

using System;
using InTheHand.Net;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Text;

namespace LitDev
{
    class BluetoothServiceItem
    {
        public Guid guid;
        public string name;

        public BluetoothServiceItem(Guid guid, string name)
        {
            this.guid = guid;
            this.name = name;
        }
    }

    /// <summary>
    /// BlueTooth control.
    /// The Advanced features refer to non file transfer (effectively writing a device driver).
    /// To communicate with a USB bluetooth stick you also need have an external bluetooth device, setting it to be dicoverable etc before running your SmallBasic program.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDBlueTooth
    {
        static LDBlueTooth()
        {
            Instance.Verify();
        }

        private static BluetoothRadio localRadio = null;
        private static BluetoothDeviceInfo localRadioInfo = null;
        private static BluetoothClient bluetoothClient = null;
        private static List<BluetoothDeviceInfo> bluetoothDeviceInfos = new List<BluetoothDeviceInfo>();
        private static List<BluetoothServiceItem> bluetoothServiceItems = new List<BluetoothServiceItem>();
        private static StreamWriter bluetoothStreamWriter = null;
        private static StreamReader bluetoothStreamReader = null;
        private static Encoding encoding = Encoding.Default;
        private static string device = "";
        private static string service = "";
        private static string lastError = "";
        private static string lastDevice = "";

        private static SBCallback _InRangeDelegate = null;
        private static void inRangeEvent(object sender, BluetoothWin32RadioInRangeEventArgs e)
        {
            setDevices();
            lastDevice = e.Device.DeviceName;
            if (null == _InRangeDelegate) return;
            _InRangeDelegate();
        }

        private static SBCallback _OutOfRangeDelegate = null;
        private static void outOfRangeEvent(object sender, BluetoothWin32RadioOutOfRangeEventArgs e)
        {
            setDevices();
            lastDevice = e.Device.DeviceName;
            if (null == _OutOfRangeDelegate) return;
            _OutOfRangeDelegate();
        }

        public static bool initialise()
        {
            try
            {
                localRadio = BluetoothRadio.PrimaryRadio;
                if (null == localRadio)
                {
                    lastError = "There is no Bluetooth hardware, or it uses unsupported software.";
                    return false;
                }
                localRadioInfo = new BluetoothDeviceInfo(localRadio.LocalAddress);
                if (null == localRadioInfo)
                {
                    lastError = "Bluetooth hardware exists, but failed to attach.";
                    return false;
                }
                localRadio.Mode = RadioMode.Discoverable;

                setServices();
                if (bluetoothServiceItems.Count > 0) service = bluetoothServiceItems[0].name;

                setDevices();
                if (bluetoothDeviceInfos.Count > 0) device = bluetoothDeviceInfos[0].DeviceName;

                BluetoothWin32Events.GetInstance().InRange += new EventHandler<BluetoothWin32RadioInRangeEventArgs>(inRangeEvent);
                BluetoothWin32Events.GetInstance().OutOfRange += new EventHandler<BluetoothWin32RadioOutOfRangeEventArgs>(outOfRangeEvent);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                lastError = ex.Message;
                return false;
            }
            return true;
        }

        private static void setDevices()
        {
            try
            {
                bluetoothClient = new BluetoothClient();
                //BluetoothDeviceInfo[] infos = bluetoothClient.DiscoverDevices(255, false, false, false, true);
                BluetoothDeviceInfo[] infos = bluetoothClient.DiscoverDevices();
                bluetoothDeviceInfos.Clear();
                foreach (BluetoothDeviceInfo info in infos)
                {
                    bluetoothDeviceInfos.Add(info);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                lastError = ex.Message;
            }
        }

        private static void setServices()
        {
            bluetoothServiceItems.Clear();
            FieldInfo[] fields = typeof(BluetoothService).GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly);
            foreach (FieldInfo field in fields)
            {
                Object obj = field.GetValue(null);
                if (obj.GetType() == typeof(Guid))
                {
                    BluetoothServiceItem item = new BluetoothServiceItem((Guid)obj, field.Name);
                    bluetoothServiceItems.Add(item);
                }
            }
        }

        private static BluetoothDeviceInfo GetBluetoothDeviceInfo(string name)
        {
            foreach (BluetoothDeviceInfo info in bluetoothDeviceInfos)
            {
                if (info.DeviceName == name) return info;
            }
            return null;
        }

        private static BluetoothServiceItem GetBluetoothServiceItem(string name)
        {
            foreach (BluetoothServiceItem item in bluetoothServiceItems)
            {
                if (item.name == name) return item;
            }
            return null;
        }

        /// <summary>
        /// Event when a bluetooth device comes in range.
        /// Seems to keep firing unexpectedly.
        /// </summary>
        public static event SBCallback InRange
        {
            add
            {
                _InRangeDelegate = value;
            }
            remove
            {
                _InRangeDelegate = null;
            }
        }

        /// <summary>
        /// Event when a bluetooth device goes out of range.
        /// Doesn't seem to work as expected.
        /// </summary>
        public static event SBCallback OutOfRange
        {
            add
            {
                _OutOfRangeDelegate = value;
            }
            remove
            {
                _OutOfRangeDelegate = null;
            }
        }

        /// <summary>
        /// The last device in or out of range.
        /// </summary>
        public static Primitive LastDevice
        {
            get { return lastDevice; }
        }

        /// <summary>
        /// Initialise a bluetooth USB stick and detect discoverable external devices.
        /// As devices come into or out of range the devices list is updated.
        /// </summary>
        /// <returns>"True" or "False" for success or failure configuring a bluetooth interface.</returns>
        public static Primitive Initialise()
        {
            return initialise() ? "True" : "False";
        }

        /// <summary>
        /// Get the last error message.
        /// Error messages may be set for various failures.
        /// </summary>
        public static Primitive LastError
        {
            get { return lastError; }
        }

        /// <summary>
        /// The number of bytes of data received and waiting to be read.
        /// This could be used in a Timer to check for data received.
        /// </summary>
        public static Primitive DataAvailable
        {
            get { return (null == bluetoothClient) ? 0 : bluetoothClient.Available; }
        }

        /// <summary>
        /// Get a list of discovered bluetooth devices.
        /// </summary>
        /// <returns>An array of devices or "" on failure.</returns>
        public static Primitive GetDevices()
        {
            string result = "";
            int i = 1;
            foreach (BluetoothDeviceInfo info in bluetoothDeviceInfos)
            {
                result += (i++).ToString() + "=" + Utilities.ArrayParse(info.DeviceName) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Advanced feature.
        /// Get a list of available service protocols.
        /// </summary>
        /// <returns>An array of services or "" on failure.</returns>
        public static Primitive GetServices()
        {
            string result = "";
            int i = 1;
            foreach (BluetoothServiceItem item in bluetoothServiceItems)
            {
                result += (i++).ToString() + "=" + Utilities.ArrayParse(item.name) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Advanced feature.
        /// Get a list of available encodings.
        /// </summary>
        /// <returns>An array of encodings or "" on failure.</returns>
        public static Primitive GetEncodings()
        {
            string result = "";
            int i = 1;
            result += i++ + "=ASCII;";
            result += i++ + "=BigEndianUnicode;";
            result += i++ + "=Default;";
            result += i++ + "=Unicode;";
            result += i++ + "=UTF32;";
            result += i++ + "=UTF7;";
            result += i++ + "=UTF8;";
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// The current bluetooth device.
        /// </summary>
        public static Primitive Device
        {
            get { return device; }
            set { device = value; }
        }

        /// <summary>
        /// Advanced feature.
        /// The current bluetooth service.
        /// </summary>
        public static Primitive Service
        {
            get { return service; }
            set { service = value; }
        }

        /// <summary>
        /// Advanced feature.
        /// The current bluetooth data encoding.
        /// </summary>
        public static Primitive Encode
        {
            get
            {
                if (encoding == Encoding.ASCII) return "ASCII";
                else if (encoding == Encoding.BigEndianUnicode) return "BigEndianUnicode";
                else if (encoding == Encoding.Default) return "Default";
                else if (encoding == Encoding.Unicode) return "Unicode";
                else if (encoding == Encoding.UTF32) return "UTF32";
                else if (encoding == Encoding.UTF7) return "UTF7";
                else if (encoding == Encoding.UTF8) return "UTF8";
                else return ""; 
            }
            set
            {
                string lower = ((string)value).ToLower();
                if (lower == "ascii") encoding = Encoding.ASCII;
                else if (lower == "bigendianunicode") encoding = Encoding.BigEndianUnicode;
                else if (lower == "default") encoding = Encoding.Default;
                else if (lower == "unicode") encoding = Encoding.Unicode;
                else if (lower == "utf32") encoding = Encoding.UTF32;
                else if (lower == "utf7") encoding = Encoding.UTF7;
                else if (lower == "utf8") encoding = Encoding.UTF8;
                else encoding = Encoding.Default;
            }
        }

        /// <summary>
        /// Advanced feature.
        /// Connect an external device and service to the bluetooth USB stick.
        /// You must first Initialise, then set the device, service and encoding.
        /// </summary>
        /// <returns>"True" or "False" on success or failure.</returns>
        public static Primitive Connect()
        {
            BluetoothDeviceInfo info = GetBluetoothDeviceInfo(device);
            BluetoothServiceItem item = GetBluetoothServiceItem(service);
            if (null == info || null == item || null == bluetoothClient)
            {
                lastError = "Device, service or client not set";
                return "False";
            }
            try
            {
                bluetoothClient.Connect(info.DeviceAddress, item.guid);
                bluetoothStreamWriter = new StreamWriter(bluetoothClient.GetStream(), encoding);
                bluetoothStreamReader = new StreamReader(bluetoothClient.GetStream(), encoding);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                lastError = ex.Message;
                return "False";
            }
            return "True";
        }

        /// <summary>
        /// Advanced feature.
        /// Send data to a bluetooth device.
        /// The device must be Initialised and Connected.
        /// The encoding should also be set.
        /// </summary>
        /// <param name="data">A string of characters to send.</param>
        /// <returns>A result status message "True" or "False".</returns>
        public static Primitive SendData(Primitive data)
        {
            BluetoothDeviceInfo info = GetBluetoothDeviceInfo(device);
            BluetoothServiceItem item = GetBluetoothServiceItem(service);
            if (null == info || null == item || null == bluetoothClient)
            {
                lastError = "Device, service or client not set";
                return "False";
            }
            if (null == bluetoothStreamWriter)
            {
                lastError = "Cannot write to device.";
                return "False";
            }
            try
            {
                bluetoothStreamWriter.Write((string)data);
                bluetoothStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                lastError = ex.Message;
                return "False";
            }
            return "True";
        }

        /// <summary>
        /// Advanced feature.
        /// Receive (fetch) data from a bluetooth device.
        /// The device must be Initialised and Connected.
        /// The encoding should also be set.
        /// </summary>
        /// <returns>String of received characters or "" on failure.</returns>
        public static Primitive ReceiveData()
        {
            string result = "";
            BluetoothDeviceInfo info = GetBluetoothDeviceInfo(device);
            BluetoothServiceItem item = GetBluetoothServiceItem(service);
            if (null == info || null == item || null == bluetoothClient)
            {
                lastError = "Device, service or client not set";
                return result;
            }
            if (null == bluetoothStreamReader)
            {
                lastError = "Cannot read from device.";
                return result;
            }
            try
            {
                Char[] buf = new Char[100];
                int numRead = 1;
                while (numRead > 0)
                {
                    numRead = bluetoothStreamReader.Read(buf, 0, buf.Length);
                    if (numRead > 0) result += new string(buf, 0, numRead);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                lastError = ex.Message;
                return result;
            }
            return result;
        }

        /// <summary>
        /// Send a file to an attached external bluetooth device.
        /// You must first Initialise, then set the device.
        /// </summary>
        /// <param name="fileName">The file to send.</param>
        /// <returns>A result status message "True" or "False".</returns>
        public static Primitive SendFile(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "False";
            }
            BluetoothDeviceInfo info = GetBluetoothDeviceInfo(device);
            if (null == info)
            {
                lastError = "Device not set";
                return "False";
            }
            try
            {
                Uri uri = new Uri("obex://" + info.DeviceAddress.ToString() + "/" + System.IO.Path.GetFileName(fileName));
                ObexWebRequest request = new ObexWebRequest(uri);
                request.ReadFile(fileName);
                ObexWebResponse response = (ObexWebResponse)request.GetResponse();
                if (response.StatusCode.ToString().Contains("OK"))
                {
                    return "True";
                }
                else
                {
                    lastError = response.StatusCode.ToString();
                    return "False";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                lastError = ex.Message;
                return "False";
            }
        }

        /// <summary>
        /// Receive (fetch) a file from an attached external bluetooth device.
        /// You must first Initialise, then set the device.
        /// </summary>
        /// <param name="fileName">The location to save the received file.</param>
        /// <returns>A result status message "True" or "False".</returns>
        public static Primitive ReceiveFile(Primitive fileName)
        {
            BluetoothDeviceInfo info = GetBluetoothDeviceInfo(device);
            if (null == info || null == bluetoothClient)
            {
                lastError = "Device or client not set";
                return "False";
            }
            try
            {
                ObexListener ol = new ObexListener(ObexTransport.Bluetooth);
                ol.Start();
                while (ol.IsListening)
                {
                    try
                    {
                        ObexListenerContext olc = ol.GetContext();
                        ObexListenerRequest olr = olc.Request;
                        olr.WriteFile(fileName);
                        ol.Stop();
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        lastError = ex.Message;
                        return "False";
                    }
                }
                return "True";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                lastError = ex.Message;
                return "False";
            }
        }
    }
}
