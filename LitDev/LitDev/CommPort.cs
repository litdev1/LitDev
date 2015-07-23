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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

// Serial Port extension originally by Nino Carrillo

using Microsoft.SmallBasic.Library;
using System;
using System.IO.Ports;
using System.Text;

namespace LitDev
{
    /// <summary>
    /// Sends and receives data over the serial port
    /// Original Code by Nino Carrillo
    /// </summary>
    [SmallBasicType]
    public static class LDCommPort
    {
        private static SerialPort _tty = null;
        private static string _portname;
        private static bool ComparePortName(String s)
        {
            return (s == _portname);
        }

        private static SmallBasicCallback DataReceivedDelegate = null;
        private static void DataReceivedEvent(Object sender, SerialDataReceivedEventArgs e)
        {
            if (null != DataReceivedDelegate) DataReceivedDelegate();
        }

        /// <summary>
        /// Event when the serial port receives data.
        /// </summary>
        public static event SmallBasicCallback DataReceived
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
        /// Opens a serial port for use.  Assumes 8 databits, no parity.
        /// </summary>
        /// <param name="portname">
        /// String identifying which port to open in the form of "COM8".  If the passed string is invalid or the port doesn't exist, the highest available port is opened.
        /// </param>
        /// <param name="baudrate">
        /// Integer baud rate.
        /// </param>
        /// <returns>Error message, "SUCCESS", "NOSERIALPORTS", "PORTNOTFOUND" or "CONNECTIONFAILED".
        /// "</returns>
        public static Primitive OpenPort(Primitive portname, Primitive baudrate)
        {
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length == 0) return "NOSERIALPORTS";
            _portname = ((string)portname).ToUpper();

            if (System.Array.Exists(portnames, ComparePortName))
            {
                try
                {
                    _tty = new SerialPort(_portname, baudrate, Parity.None, 8, StopBits.One);
                    _tty.Open();
                    _tty.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEvent);
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
        /// Reads one byte from the open serial port and returns that byte as an integer.
        /// </summary>
        /// <returns>
        /// One integer value between 0 and 255 ("NOCONNECTION" or "FAILED" on failure).
        /// </returns>
        public static Primitive RXByte()
        {
            if (null == _tty) return "NOCONNECTION";
            try
            {
                return _tty.ReadByte();
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
            if (null == _tty) return "NOCONNECTION";
            try
            {
                return Convert.ToString(_tty.ReadByte());
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
            if (null == _tty) return "NOCONNECTION";
            try
            {
                return _tty.ReadExisting();
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
            if (null == _tty) return "NOCONNECTION";
            try
            {
                _tty.Close();
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
            foreach (string s in portnames)
            {
                portlist[count++] = s;
            }
            return portlist;
        }

        /// <summary>
        /// Sends one byte to the serial port.
        /// </summary>
        /// <param name="databyte">
        /// The byte to be written to the port.
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive TXByte(Primitive databyte)
        {
            if (null == _tty) return "NOCONNECTION";
            try
            {
                byte[] b = { (byte)databyte };
                _tty.Write(b, 0, 1);
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
        /// <param name="datastring">
        /// String value to be sent.
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive TXString(Primitive datastring)
        {
            if (null == _tty) return "NOCONNECTION";
            try
            {
                _tty.Write(datastring);
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Sets or clears hardware flow control.
        /// </summary>
        /// <param name="handshake">
        /// "H" or "h" to select hardware flow control, any other character to clear.
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive SetHandshake(Primitive handshake)
        {
            if (null == _tty) return "NOCONNECTION";
            try
            {
                string _handshake = ((string)handshake).ToUpper();
                if (_handshake == "H")
                {
                    _tty.Handshake = Handshake.RequestToSend;
                }
                else
                {
                    _tty.Handshake = Handshake.None;
                }
                return "SUCCESS";
            }
            catch
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Sets the encoding for send and receive text conversion.
        /// </summary>
        /// <param name="encoding">The encoding:
        /// "Ascii" (default), "Unicode", "UTF7", "UTF8", "UTF32" or "BigEndianUnicode".
        /// </param>
        /// <returns>
        /// "SUCCESS", "NOCONNECTION" or "FAILED".
        /// </returns>
        public static Primitive SetEncoding(Primitive encoding)
        {
            if (null == _tty) return "NOCONNECTION";
            try
            {
                string _encoding = ((string)encoding).ToUpper();
                if (_encoding == "ASCII")
                {
                    _tty.Encoding = Encoding.ASCII;
                }
                else if (_encoding == "UNICODE")
                {
                    _tty.Encoding = Encoding.Unicode;
                }
                else if (_encoding == "UTF7")
                {
                    _tty.Encoding = Encoding.UTF7;
                }
                else if (_encoding == "UTF8")
                {
                    _tty.Encoding = Encoding.UTF8;
                }
                else if (_encoding == "UTF32")
                {
                    _tty.Encoding = Encoding.UTF32;
                }
                else if (_encoding == "BIGENDIANUNICODE")
                {
                    _tty.Encoding = Encoding.BigEndianUnicode;
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
