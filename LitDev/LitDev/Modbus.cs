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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using Modbus.Device;
using System.Net.Sockets;
using System;
using SlimDX;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using Modbus.Message;
using System.Net.Mail;

namespace LitDev
{
    /// <summary>
    /// Modbus I/O utility.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDModbus
    {
        private static ModbusIpMaster master = null;

        static LDModbus()
        {
            Instance.Verify();
        }

        /// <summary>
        /// Connect to master using TCP/IP
        /// </summary>
        /// <param name="address">IP address string, e.g. "127.0.0.1"</param>
        /// <param name="port">Port number, e.g. 502</param>
        /// <returns>"SUCCESS" or "FAILED"</returns>
        public static Primitive ConnectTcp(Primitive address, Primitive port)
        {
            try
            {
                TcpClient client = new TcpClient(address, port);
                master = ModbusIpMaster.CreateIp(client);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Connect to master using UDP
        /// </summary>
        /// <param name="address">IP address string, e.g. "127.0.0.1"</param>
        /// <param name="port">Port number, e.g. 502</param>
        /// <returns>"SUCCESS" or "FAILED"</returns>
        public static Primitive ConnectUdp(Primitive address, Primitive port)
        {
            try
            {
                UdpClient client = new UdpClient(address, port);
                master = ModbusIpMaster.CreateIp(client);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Connect to master using Serial port
        /// </summary>
        /// <param name="portname">IP address string, e.g. "COM1"</param>
        /// <param name="baudrate">Baud rate, e.g. 9600</param>
        /// <returns>"SUCCESS" or "FAILED"</returns>
        public static Primitive ConnectSerial(Primitive portname, Primitive baudrate)
        {
            try
            {
                SerialPort serialPort = new SerialPort(portname, baudrate);
                master = ModbusIpMaster.CreateIp(serialPort);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Read Input data, discrete input data ("True" or "False")
        /// </summary>
        /// <param name="slave">The client number, 0 to 247</param>
        /// <param name="start">The first input to read (1 to 9999)</param>
        /// <param name="number">The number of inputs to read</param>
        /// <returns>An array of results (if number is 1 then a single value is returned) or "FAILED"</returns>
        public static Primitive ReadInputs(Primitive slave, Primitive start, Primitive number)
        {
            try
            {
                byte slaveAddress = (byte)slave;
                ushort startAddress = (ushort)start;
                ushort numInputs = (ushort)number;
                bool[] result = master.ReadInputs(slaveAddress, startAddress, numInputs);
                if (result == null) return "FAILED";
                else if (result.Length == 1)
                {
                    return result[0] ? "True" : "False";
                }
                else
                {
                    StringBuilder _SBarray = new StringBuilder();
                    for (int i = 0; i < result.Length; i++)
                    {
                        _SBarray.AppendFormat("{0}={1};", (i + 1), result[i] ? "True" : "False");
                    }
                    return Utilities.CreateArrayMap(_SBarray.ToString());
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Read Coil data, discrete output data ("True" or "False")
        /// </summary>
        /// <param name="slave">The client number, 0 to 247</param>
        /// <param name="start">The first coil to read (1 to 9999)</param>
        /// <param name="number">The number of coils to read</param>
        /// <returns>An array of results (if number is 1 then a single value is returned) or "FAILED"</returns>
        public static Primitive ReadCoils(Primitive slave, Primitive start, Primitive number)
        {
            try
            {
                byte slaveAddress = (byte)slave;
                ushort startAddress = (ushort)start;
                ushort numInputs = (ushort)number;
                bool[] result = master.ReadCoils(slaveAddress, startAddress, numInputs);
                if (result == null) return "FAILED";
                else if (result.Length == 1)
                {
                    return result[0] ? "True" : "False";
                }
                else
                {
                    StringBuilder _SBarray = new StringBuilder();
                    for (int i = 0; i < result.Length; i++)
                    {
                        _SBarray.AppendFormat("{0}={1};", (i + 1), result[i] ? "True" : "False");
                    }
                    return Utilities.CreateArrayMap(_SBarray.ToString());
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Read Input register data, discrete input data (16 bit unsigned integer)
        /// </summary>
        /// <param name="slave">The client number, 0 to 247</param>
        /// <param name="start">The first input register to read (1 to 9999)</param>
        /// <param name="number">The number of input registers to read</param>
        /// <returns>An array of results (if number is 1 then a single value is returned) or "FAILED"</returns>
        public static Primitive ReadInputRegisters(Primitive slave, Primitive start, Primitive number)
        {
            try
            {
                byte slaveAddress = (byte)slave;
                ushort startAddress = (ushort)start;
                ushort numInputs = (ushort)number;
                ushort[] result = master.ReadInputRegisters(slaveAddress, startAddress, numInputs);
                if (result == null) return "FAILED";
                else if (result.Length == 1)
                {
                    return result[0];
                }
                else
                {
                    StringBuilder _SBarray = new StringBuilder();
                    for (int i = 0; i < result.Length; i++)
                    {
                        _SBarray.AppendFormat("{0}={1};", (i + 1), result[i]);
                    }
                    return Utilities.CreateArrayMap(_SBarray.ToString());
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Read Holding register data, discrete output data (16 bit unsigned integer)
        /// </summary>
        /// <param name="slave">The client number, 0 to 247</param>
        /// <param name="start">The first holding register to read (1 to 9999)</param>
        /// <param name="number">The number of holding registers to read</param>
        /// <returns>An array of results (if number is 1 then a single value is returned) or "FAILED"</returns>
        public static Primitive ReadHoldingRegisters(Primitive slave, Primitive start, Primitive number)
        {
            try
            {
                byte slaveAddress = (byte)slave;
                ushort startAddress = (ushort)start;
                ushort numInputs = (ushort)number;
                ushort[] result = master.ReadHoldingRegisters(slaveAddress, startAddress, numInputs);
                if (result == null) return "FAILED";
                else if (result.Length == 1)
                {
                    return result[0];
                }
                else
                {
                    StringBuilder _SBarray = new StringBuilder();
                    for (int i = 0; i < result.Length; i++)
                    {
                        _SBarray.AppendFormat("{0}={1};", (i + 1), result[i]);
                    }
                    return Utilities.CreateArrayMap(_SBarray.ToString());
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Write Coil data, discrete output data ("True" or "False")
        /// </summary>
        /// <param name="slave">The client number, 0 to 247</param>
        /// <param name="address">The coil to write (1 to 9999)</param>
        /// <param name="value">The coil value ("True" or "False")</param>
        /// <returns>"SUCCESS" or "FAILED"</returns>
        public static Primitive WriteCoil(Primitive slave, Primitive address, Primitive value)
        {
            try
            {
                byte slaveAddress = (byte)slave;
                ushort _address = (ushort)address;
                bool _value = (bool)value;
                master.WriteSingleCoil(slaveAddress, _address, _value);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Write Holding register data, discrete output data (16 bit unsigned integer)
        /// </summary>
        /// <param name="slave">The client number, 0 to 247</param>
        /// <param name="address">The holding register to write (1 to 9999)</param>
        /// <param name="value">The holding register value (0 to 65535)</param>
        /// <returns>"SUCCESS" or "FAILED"</returns>
        public static Primitive WriteRegister(Primitive slave, Primitive address, Primitive value)
        {
            try
            {
                byte slaveAddress = (byte)slave;
                ushort _address = (ushort)address;
                ushort _value = (ushort)value;
                master.WriteSingleRegister(slaveAddress, _address, _value);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }
    }
}
