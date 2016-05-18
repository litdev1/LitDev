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

using Microsoft.SmallBasic.Library;
using System;
using System.Management;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using LitDev.Engines;

namespace LitDev
{
    public delegate void HIDChangedEventHandler(object sender, HIDChangedEventArgs args);
    public class HIDChangedEventArgs : EventArgs
    {
        public readonly HIDInputReport oHIDIn;

        public HIDChangedEventArgs(HIDInputReport oHIDIn)
        {
            this.oHIDIn = oHIDIn;
        }
    }

    public class HIDOutputReport : OutputReport
    {
        public HIDOutputReport(HID_Device oDev) : base(oDev)
        {
        }

        public bool SendData(int[] input)
        {
            byte[] arrBuff = Buffer;
            if (input.Length != arrBuff.Length) return false;
            for (int i = 0; i < input.Length; i++)
            {
                arrBuff[i] = (byte)input[i];
            }
            return true;
        }
    }

    public class HIDInputReport : InputReport
    {
        public string name = "";

        public HIDInputReport(HID_Device oDev) : base(oDev)
        {
            name = oDev.name;
        }

        public override void ProcessData()
        {
            byte[] arrData = Buffer;
        }
    }

    public class HID_Device : HIDDevice
    {
        public int VID;
        public int PID;
        public string name;

        public event HIDChangedEventHandler OnDeviceChanged = null;

        public override InputReport CreateInputReport()
        {
            return new HIDInputReport(this);
        }

        protected override void HandleDataReceived(InputReport oInRep)
        {
            if (OnDeviceChanged != null)
            {
                HIDInputReport oHIDIn = (HIDInputReport)oInRep;
                OnDeviceChanged(this, new HIDChangedEventArgs(oHIDIn));
            }
        }

        protected override void Dispose(bool bDisposing)
        {
            if (bDisposing)
            {
            }
            base.Dispose(bDisposing);
        }
    }

    /// <summary>
    /// USB control for HID (Human Interface Devices).
    /// The VID and PID (4 character hex codes) for the device are required.
    /// Only HIDs will work using these methods.
    /// Hopefully this includes most game controllers, simple robotic devices and sensors.
    /// </summary>
    [SmallBasicType]
    public static class LDHID
    {
        private static List<HID_Device> HID_Devices = new List<HID_Device>();
        private static byte[] lastInput = null;
        private static string lastDevice = "";

        private static SmallBasicCallback _OnHIDInput = null;
        private static void _OnDeviceChanged(object sender, HIDChangedEventArgs args)
        {
            lastInput = args.oHIDIn.Buffer;
            lastDevice = args.oHIDIn.name;
            if (null != _OnHIDInput) _OnHIDInput();
        }

        private static SmallBasicCallback _OnHIDRemoved = null;
        private static void _OnDeviceRemoved(object sender, EventArgs args)
        {
            if (null != _OnHIDRemoved) _OnHIDRemoved();
        }

        private static bool DeviceExists(int VID, int PID, string name)
        {
            foreach (HID_Device device in HID_Devices)
            {
                if ((device.VID == VID && device.PID == PID) || device.name == name) return true;
            }
            return false;
        }

        private static HID_Device GetDevice(string name)
        {
            foreach (HID_Device device in HID_Devices)
            {
                if (device.name == name) return device;
            }
            return null;
        }

        private static bool CreateDevice(string VID, string PID, string name)
        {
            try
            {
                int iVID = -1;
                int iPID = -1;
                int.TryParse(VID, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out iVID);
                int.TryParse(PID, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out iPID);
                if (DeviceExists(iVID, iPID, name)) return false;

                if (iVID >= 0 && iPID >= 0)
                {
                    HID_Device myDevice = (HID_Device)HID_Device.FindDevice(iVID, iPID, typeof(HID_Device));
                    if (null != myDevice)
                    {
                        myDevice.VID = iVID;
                        myDevice.PID = iPID;
                        myDevice.name = name;
                        HID_Devices.Add(myDevice);
                        myDevice.OnDeviceRemoved += new EventHandler(_OnDeviceRemoved);
                        myDevice.OnDeviceChanged += new HIDChangedEventHandler(_OnDeviceChanged);
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return false;
        }

        private static List<List<string>> FindAllDevices()
        {
            List<List<string>> devices = new List<List<string>>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + "Win32_USBControllerDevice");
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("select * from " + "Win32_PnPEntity");
            foreach (ManagementObject device in searcher.Get())
            {
                string dev = device.ToString();
                int pos1 = dev.IndexOf("VID_");
                int pos2 = dev.IndexOf("PID_");
                if (pos1 >= 0 && pos2 >= 0)
                {
                    List<string> props = new List<string>();
                    props.Add(dev.Substring(pos1+4,4));
                    props.Add(dev.Substring(pos2+4,4));
                    bool found = false;
                    foreach (List<string> i in devices)
                    {
                        if (i[0] == props[0] && i[1] == props[1]) found = true;
                    }
                    if (!found)
                    {
                        string description = "Unknown";
                        foreach (ManagementObject device2 in searcher2.Get())
                        {
                            string search = dev.Substring(pos1, 17);
                            if (device2.ToString().IndexOf(search) >= 0)
                            {
                                description = (string)device2.GetPropertyValue("Caption");
                            }
                        }
                        props.Add(description);

                        devices.Add(props);
                    }
                }
            }
            return devices;
        }

        /// <summary>
        /// Event when the HID input changes.
        /// </summary>
        public static event SmallBasicCallback Input
        {
            add
            {
                _OnHIDInput = value;
            }
            remove
            {
                _OnHIDInput = null;
            }
        }

        /// <summary>
        /// An array of the last HID input data.
        /// This a set of values from 0 to 255 (bytes).
        /// </summary>
        /// <returns>An array of input data or "" for none.</returns>
        public static Primitive LastInput
        {
            get 
            {
                string result = "";
                if (null != lastInput)
                {
                    for (int i = 0; i < lastInput.Length; i++)
                    {
                        result += (i + 1) + "=" + lastInput[i] + ";";
                    }
                }
                return Utilities.CreateArrayMap(result);
            }
        }

        /// <summary>
        /// Get the input record length for a HID device.
        /// </summary>
        /// <param name="name">The device name.</param>
        /// <returns>The number of bytes in the input record.</returns>
        public static Primitive InputLength(Primitive name)
        {
            HID_Device device = GetDevice(name);
            if (null == device) return 0;
            return device.InputReportLength;
        }

        /// <summary>
        /// Get the output record length for a HID device.
        /// </summary>
        /// <param name="name">The HID device name.</param>
        /// <returns>The number of bytes in the output record.</returns>
        public static Primitive OutputLength(Primitive name)
        {
            HID_Device device = GetDevice(name);
            if (null == device) return 0;
            return device.OutputReportLength;
        }

        /// <summary>
        /// Send data to the HID device.
        /// This must be an array of bytes (0 to 255).
        /// The array must be indexed from 1 and have size OutputLength.
        /// </summary>
        /// <param name="name">The HID device name.</param>
        /// <param name="data">The data to send.</param>
        /// <returns>"True" or "False" for data consistency.</returns>
        public static Primitive Output(Primitive name, Primitive data)
        {
            try
            {
                HID_Device device = GetDevice(name);
                if (null == device) return "False";
                HIDOutputReport report = new HIDOutputReport(device);
                int[] sendData = new int[device.OutputReportLength];
                for (int i = 0; i < sendData.Length; i++)
                {
                    sendData[i] = data[i + 1];
                }
                return report.SendData(sendData);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "False";
        }

        /// <summary>
        /// The last HID device that had input.
        /// </summary>
        /// <returns>The last device name.</returns>
        public static Primitive LastDevice
        {
            get
            {
                return lastDevice;
            }
        }

        /// <summary>
        /// Event when the HID device is removed.
        /// </summary>
        public static event SmallBasicCallback Removed
        {
            add
            {
                _OnHIDRemoved = value;
            }
            remove
            {
                _OnHIDRemoved = null;
            }
        }

        /// <summary>
        /// Add a HID connected device from its VID and PID.
        /// The VID and PID are 4 character (hex) values, and can be found from:
        /// Device Manager->Properties->Details->Hardware ids
        /// For example: HID\VID_046D PID_C215 REV_0204 has VID "046D" and PID "C215".
        /// Only add a device once.
        /// </summary>
        /// <param name="VID">The device VID.</param>
        /// <param name="PID">The device PID.</param>
        /// <param name="name">A name for the device.</param>
        /// <returns>"True" or "False" for success or failure</returns>
        public static Primitive AddDevice(Primitive VID, Primitive PID, Primitive name)
        {
            return CreateDevice(VID, PID, name) ? "True" : "False";
        }

        /// <summary>
        /// Get an 8 element array of 1s and 0s indicating which bit of a byte are set.
        /// </summary>
        /// <param name="data">A byte number (0 to 255).</param>
        /// <returns>An 8 element bit array (small bit first) or "" on failure.</returns>
        public static Primitive GetBits(Primitive data)
        {
            string result = "";
            byte bits;
            if (!byte.TryParse(data, out bits)) return result;
            result += "1=" + (bits & 0x01) / 0x01 + ";";
            result += "2=" + (bits & 0x02) / 0x02 + ";";
            result += "3=" + (bits & 0x04) / 0x04 + ";";
            result += "4=" + (bits & 0x08) / 0x08 + ";";
            result += "5=" + (bits & 0x10) / 0x10 + ";";
            result += "6=" + (bits & 0x20) / 0x20 + ";";
            result += "7=" + (bits & 0x40) / 0x40 + ";";
            result += "8=" + (bits & 0x80) / 0x80 + ";";
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Set a byte from an 8 element array of 1s and 0s indicating which bit of a byte are set.
        /// </summary>
        /// <param name="data">An 8 element array of 1s and 0s (small bit first).</param>
        /// <returns>A byte number (0 to 255) or -1 on failure.</returns>
        public static Primitive SetBits(Primitive data)
        {
            try
            {
                int result = 0;
                for (int i = 0; i < 8; i++)
                {
                    if (data[1 + i] != 0) result |= (byte)(1 << i);
                }
                return result;
            }
            catch
            {
            }
            return -1;
        }

        /// <summary>
        /// List all found HID (Human Interface Devices).
        /// </summary>
        /// <returns>A 2D array of all found devices.
        /// The first dimension is the found device indexed from 1.
        /// The second dimension is "VID", "PID" and "Description" holding the hex values of VID, PID and a device description.
        /// </returns>
        public static Primitive FindDevices()
        {
            Primitive result = "";
            List<List<string>> devices = FindAllDevices();
            int i = 1;
            foreach (List<string> device in devices)
            {
                Primitive dev = "";
                dev["VID"] = device[0];
                dev["PID"] = device[1];
                dev["Description"] = device[2];
                result[i++] = dev;
            }
            return Utilities.CreateArrayMap(result);
        }
    }
}
