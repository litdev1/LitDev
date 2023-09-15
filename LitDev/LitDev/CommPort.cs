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

// Serial Port extension originally by Nino Carrillo

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace LitDev
{
    /// <summary>
    /// Sends and receives data over the serial port
    /// Original Code by Nino Carrillo
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDCommPort
    {
        private static Dictionary<string, SerialPort> ports = new Dictionary<string, SerialPort>();
        private static SerialPort port = null;
        private static string lastPort = "";
        private static string lastError = "";

        private static SBCallback DataReceivedDelegate = null;
        private static void DataReceivedEvent(Object sender, SerialDataReceivedEventArgs e)
        {
            lastPort = ((SerialPort)sender).PortName;
            if (null != DataReceivedDelegate) DataReceivedDelegate();
        }

        private static SBCallback ErrorReceivedDelegate = null;
        private static void ErrorReceivedEvent(Object sender, SerialErrorReceivedEventArgs e)
        {
            lastPort = ((SerialPort)sender).PortName;
            lastError = e.EventType.ToString();
            if (null != ErrorReceivedDelegate) ErrorReceivedDelegate();
        }

        /// <summary>
        /// The last port name for which an event was raised.
        /// </summary>
        public static Primitive LastPort
        {
            get { return lastPort; }
        }

        /// <summary>
        /// The last error for which an error event was raised.
        /// </summary>
        public static Primitive LastError
        {
            get { return lastError; }
        }

        /// <summary>
        /// Event when the serial port receives data.
        /// </summary>
        public static event SBCallback DataReceived
        {
            add
            {
                DataReceivedDelegate = value;
            }
            remove
            {
                DataReceivedDelegate = null;
            }
        }

        /// <summary>
        /// Event when the serial port receives an error.
        /// </summary>
        public static event SBCallback ErrorReceived
        {
            add
            {
                ErrorReceivedDelegate = value;
            }
            remove
            {
                ErrorReceivedDelegate = null;
            }
        }

        /// <summary>
        /// Opens a serial port for use.  Assumes 8 databits, no parity.
        /// </summary>
        /// <param name="portName">
        /// String identifying which port to open in the form of "COM8".
        /// </param>
        /// <param name="baudRate">
        /// Integer baud rate, for example 9600.
        /// </param>
        /// <returns>Error message, "SUCCESS", "NOSERIALPORTS", "PORTNOTFOUND" or "CONNECTIONFAILED".
        /// </returns>
        public static Primitive OpenPort(Primitive portName, Primitive baudRate)
        {
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length == 0) return "NOSERIALPORTS";
            string _portName = ((string)portName).ToUpper();
            if (ports.TryGetValue(_portName, out port))
            {
                port.BaudRate = baudRate;
                return "SUCCESS";
            }

            if (System.Array.Exists(portnames, element => element == _portName))
            {
                try
                {
                    port = new SerialPort(_portName, baudRate);
                    port.PortName = _portName;
                    ports[_portName] = port;
                    port.Open();
                    port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEvent);
                    port.ErrorReceived += new SerialErrorReceivedEventHandler(ErrorReceivedEvent);
                    return "SUCCESS";
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "CONNECTIONFAILED";
                }
            }
            else
            {
                return "PORTNOTFOUND";
            }
        }

        /// <summary>
        /// Switch the current active port to a previously opened port.
        /// </summary>
        /// <param name="portName">String identifying a port that is already opened.</param>
        /// <returns>Error message, "SUCCESS" or "PORTNOTFOUND".</returns>
        public static Primitive SwapPort(Primitive portName)
        {
            SerialPort _port;
            if (!ports.TryGetValue(((string)portName).ToUpper(), out _port)) return "PORTNOTFOUND";
            port = _port;
            return "SUCCESS";
        }

        /// <summary>
        /// Reads one byte from the open serial port and returns that byte as an integer.
        /// </summary>
        /// <returns>
        /// One integer value between 0 and 255 ("NOCONNECTION" or "FAILED" on failure).
        /// </returns>
        public static Primitive RXByte()
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                return port.ReadByte();
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Reads one byte from the open serial port and returns that byte as a unicode character.
        /// </summary>
        /// <returns>
        /// One unicode character ("NOCONNECTION" or "FAILED" on failure).
        /// </returns>
        public static Primitive RXChar()
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                return Convert.ToString(port.ReadByte());
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Reads all available bytes in the open comm port input buffer.
        /// </summary>
        /// <returns>
        /// Returns a string of bytes ("NOCONNECTION" or "FAILED" on failure).
        /// </returns>
        public static Primitive RXAll()
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                return port.ReadExisting();
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Closes the open serial port.
        /// </summary>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive ClosePort()
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                port.Close();
                ports.Remove(port.PortName);
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Returns a list of available serial ports.
        /// </summary>
        /// <returns>
        /// An array containing the names of available serial ports.
        /// </returns>
        public static Primitive AvailablePorts()
        {
            string[] portnames = SerialPort.GetPortNames();
            Primitive portlist = "";
            int count = 1;
            foreach (string portname in portnames)
            {
                portlist[count++] = portname;
            }
            return portlist;
        }

        /// <summary>
        /// Sends one byte to the serial port.
        /// </summary>
        /// <param name="dataByte">
        /// The byte to be written to the port.
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive TXByte(Primitive dataByte)
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                byte[] b = { (byte)dataByte };
                port.Write(b, 0, 1);
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Sends a string to the serial port.
        /// </summary>
        /// <param name="dataString">
        /// String value to be sent.
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive TXString(Primitive dataString)
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                port.Write(dataString);
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Sets or clears hardware flow control for the current port.
        /// </summary>
        /// <param name="handshake">
        /// "H" to select hardware flow control, "HX" for hardware and software flow control, "X" for software fow control, any other character to clear.
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive SetHandshake(Primitive handshake)
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                string value = ((string)handshake).ToUpper();
                if (value == "H")
                {
                    port.Handshake = Handshake.RequestToSend;
                }
                if (value == "HX")
                {
                    port.Handshake = Handshake.RequestToSendXOnXOff;
                }
                if (value == "X")
                {
                    port.Handshake = Handshake.XOnXOff;
                }
                else
                {
                    port.Handshake = Handshake.None;
                }
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Sets current port encoding for send and receive text conversion.
        /// </summary>
        /// <param name="encoding">The encoding:
        /// "Ascii" (default), "Unicode", "UTF7", "UTF8", "UTF32" or "BigEndianUnicode".
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive SetEncoding(Primitive encoding)
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                string value = ((string)encoding).ToUpper();
                if (value == "ASCII")
                {
                    port.Encoding = Encoding.ASCII;
                }
                else if (value == "UNICODE")
                {
                    port.Encoding = Encoding.Unicode;
                }
                else if (value == "UTF7")
                {
                    port.Encoding = Encoding.UTF7;
                }
                else if (value == "UTF8")
                {
                    port.Encoding = Encoding.UTF8;
                }
                else if (value == "UTF32")
                {
                    port.Encoding = Encoding.UTF32;
                }
                else if (value == "BIGENDIANUNICODE")
                {
                    port.Encoding = Encoding.BigEndianUnicode;
                }
                else
                {
                    return "FAILED";
                }
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Sets current port parity. 
        /// </summary>
        /// <param name="parity">The parity:
        /// "None" (default), "Even", "Mark", "Odd" or "Space".
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive SetParity(Primitive parity)
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                string value = ((string)parity).ToUpper();
                if (value == "NONE")
                {
                    port.Parity = Parity.None;
                }
                else if (value == "EVEN")
                {
                    port.Parity = Parity.Even;
                }
                else if (value == "MARK")
                {
                    port.Parity = Parity.Mark;
                }
                else if (value == "ODD")
                {
                    port.Parity = Parity.Odd;
                }
                else if (value == "Space")
                {
                    port.Parity = Parity.Space;
                }
                else
                {
                    return "FAILED";
                }
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Sets current port data bits. 
        /// 5 to 8 (default).
        /// </summary>
        /// <param name="dataBits">The data bits:
        /// 5 to 8 (default).
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive SetDataBits(Primitive dataBits)
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                port.DataBits = dataBits;
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Current port stop bits. 
        /// </summary>
        /// <param name="stopBits">The stop bits:
        /// "One" (default), "None", "OnePointFive" or "Two".
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive SetStopBits(Primitive stopBits)
        {
            if (null == port) return "NOCONNECTION";
            try
            {
                string value = ((string)stopBits).ToUpper();
                if (value == "NONE")
                {
                    port.StopBits = StopBits.None;
                }
                else if (value == "ONE")
                {
                    port.StopBits = StopBits.One;
                }
                else if (value == "ONEPOINTFIVE")
                {
                    port.StopBits = StopBits.OnePointFive;
                }
                else if (value == "TWO")
                {
                    port.StopBits = StopBits.Two;
                }
                else
                {
                    return "FAILED";
                }
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }
    }
}
