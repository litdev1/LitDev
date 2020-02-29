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

using Microsoft.SmallBasic.Library;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    /// <summary>
    /// Server and Client communication between computers.
    /// Separate programs are required for the server and client - this is for the client.
    /// </summary>
    [SmallBasicType]
    public static class LDClient
    {
        private static TcpClient tcpClient = null;
        private static bool connected = false;
        private static bool autoMode = true;
        private static int closeDelay = 100;
        private static int timeOut = 10000;
        private static bool bReceived = false;
        private static object lockListen = new object();
        private static object lockSend = new object();

        private static string lastServerMessage = "";
        private static SmallBasicCallback _ServerMessageDelegate = null;
        private static SmallBasicCallback _DisconnectedDelegate = null;

        private static string[] colon = new string[] { ":" };
        private static Primitive clientData = "";
        private static Primitive serverData = "";
        private static Primitive thisClient;
        private static Primitive allClients = "";

        private static void Listen()
        {
            string[] separators = new string[] { "\0" };
            NetworkStream networkStream = tcpClient.GetStream();
            byte[] bytes;
            string[] messages;

            while (connected)
            {
                try
                {
                    if (tcpClient.Connected)
                    {
                        bytes = new byte[tcpClient.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, bytes.Length);
                        string dataFromClient = Encoding.UTF8.GetString(bytes);
                        messages = dataFromClient.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < messages.Length; i++)
                        {
                            string message = messages[i];
                            if (message.Length > 0)
                            {
                                ServerMessageDelegate(message);
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(10);
                    }
                }
                catch
                {
                }
            }
            tcpClient.Close();
        }

        private static string Send(string message)
        {
            lock (lockSend)
            {
                if (!tcpClient.Connected) return "NOT_CONNECTED";
                Byte[] bytes = Encoding.UTF8.GetBytes(message + '\0');
                NetworkStream networkStream = tcpClient.GetStream();
                networkStream.Write(bytes, 0, bytes.Length);
                return "SUCCESS";
            }
        }

        /// <summary>
        /// This client's name.
        /// Get or set your name.
        /// </summary>
        public static Primitive Name
        {
            get { return thisClient; }
            set
            {
                allClients = GetClients();
                string newName = value;
                string newNameTemp = newName;
                int i = 1;
                while (SBArray.ContainsValue(allClients,newName))
                {
                    newName = newNameTemp + (i++).ToString();
                }
                clientData[newName] = clientData[thisClient];
                clientData[thisClient] = "";
                thisClient = newName;
                Send("INTERNAL:NAME:" + thisClient);
            }
        }

        /// <summary>
        /// A delay in ms (default 100) when disconnecting to allow a message to be sent before connection closed (Disconnect).
        /// This delay should also be set for the server in LDServer.CloseDelay.
        /// </summary>
        public static Primitive CloseDelay
        {
            get { return closeDelay; }
            set { closeDelay = value; }
        }

        /// <summary>
        /// Test if a server is available for connection.
        /// Do not call this method at a high frequency (> 1 per second).
        /// </summary>
        /// <param name="server">The server connection ip:port (e.g. "192.168.1.60:100").
        /// This value is returned by LDServer.Start.</param>
        /// <returns>"AVAILABLE" or "UNAVAILABLE"</returns>
        public static Primitive CheckServer(Primitive server)
        {
            try
            {
                string[] data = ((string)server).Split(':');
                string ip = data[0];
                int port = int.Parse(data[1]);
                TcpClient tcpClientCheck = new TcpClient(ip, port);
                if (tcpClientCheck.Connected)
                {
                    LingerOption lingerOption = new LingerOption(false, 0);
                    tcpClientCheck.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, lingerOption);
                    tcpClientCheck.Client.Close(0);
                    return "AVAILABLE";
                }
            }
            catch
            {
            }
            return "UNAVAILABLE";
        }

        /// <summary>
        /// Connect to a server.
        /// </summary>
        /// <param name="server">The server connection ip:port (e.g. "192.168.1.60:100").
        /// This value is returned by LDServer.Start.</param>
        /// <param name="auto">Enable auto message passing "True" or "False".
        /// If this is used (recommended) then all client data is passed via server to all other clients, 
        /// and no processing of send and receive events is required.
        /// The data is updated to arrays of data (indexed by client name) that is returned from the Update methods.
        /// The auto option should be the same for server and all clients.</param>
        /// <returns>"SUCCESS", "FAILED" or "ALREADY_CONNECTED"</returns>
        public static Primitive Connect(Primitive server, Primitive auto)
        {
            try
            {
                if (connected) return "ALREADY_CONNECTED";
                autoMode = auto;
                string [] data = ((string)server).Split(':');
                string ip = data[0];
                int port = int.Parse(data[1]);
                tcpClient = new TcpClient(ip, port);
                connected = true;
                Thread thread = new Thread(new ThreadStart(Listen));
                thread.Start();
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Disconnect the client from the server.
        /// </summary>
        /// <returns>"SUCCESS", "FAILED" or "NOT_CONNECTED"</returns>
        public static Primitive Disconnect()
        {
            try
            {
                if (!connected) return "NOT_CONNECTED";
                string result = Send("DISCONNECT");
                Thread.Sleep(CloseDelay);
                connected = false;
                clientData[thisClient] = "";
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Send a message to the server.
        /// </summary>
        /// <param name="message">The message may be any variable including an array.</param>
        /// <returns>"SUCCESS", "FAILED" or "NOT_CONNECTED"</returns>
        public static Primitive SendMessage(Primitive message)
        {
            try
            {
                if (!connected) return "NOT_CONNECTED";
                Send(message);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Update client data when using the auto message passing.
        /// This is for small quantities of frequently changing data, like sprite coordinates.
        /// this method uses the last updated client data stored on the client and is therefore fast.
        /// </summary>
        /// <param name="data">The data for this client to propagate to other clients.</param>
        /// <returns>An array indexed by client names with current data for all existing clients.</returns>
        public static Primitive UpdateDynamic(Primitive data)
        {
            SendMessage(data);
            clientData[thisClient] = data;
            return clientData;
        }

        /// <summary>
        /// Update client data when using the auto message passing.
        /// This is for larger quantities of infrequently changing data, like client configuration.
        /// This method uses data stored and retrieved from the server so may be slower than UpdateDynamic since it waits for server retreived data,
        /// guaranteeing that all client data is fully synced.
        /// </summary>
        /// <param name="data">The data for this client to propagate to other clients.</param>
        /// <returns>An array indexed by client names with current data for all existing clients.</returns>
        public static Primitive UpdateStatic(Primitive data)
        {
            bReceived = false;
            SendMessage(data + ":");
            DateTime start = DateTime.Now;
            while (!bReceived && (DateTime.Now - start) < TimeSpan.FromMilliseconds(timeOut)) Thread.Sleep(1);
            return serverData;
        }

        /// <summary>
        /// Get a list of current connected clients.
        /// </summary>
        /// <returns>An array of current client names or "" for none.</returns>
        public static Primitive GetClients()
        {
            bReceived = false;
            SendMessage("INTERNAL:CLIENTS:");
            DateTime start = DateTime.Now;
            while (!bReceived && (DateTime.Now - start) < TimeSpan.FromMilliseconds(timeOut)) Thread.Sleep(1);
            return allClients;
        }

        private static void ServerMessageDelegate(string message)
        {
            lock (lockListen)
            {
                if (message.StartsWith("INTERNAL:"))
                {
                    message = message.Substring(9);
                    if (message.StartsWith("CLIENTS:"))
                    {
                        allClients = message.Substring(8);
                        bReceived = true;
                    }
                }
                else if (message == "CLOSE")
                {
                    Program.End();
                }
                else if (message == "DISCONNECT")
                {
                    connected = false;
                    clientData[thisClient] = "";
                    if (null != _DisconnectedDelegate) _DisconnectedDelegate();
                }
                else
                {
                    lastServerMessage = message;
                    if (null != _ServerMessageDelegate) _ServerMessageDelegate();
                    string[] data = message.Split(colon, StringSplitOptions.RemoveEmptyEntries);
                    string client = data[0];
                    string msg = data[1];
                    if (msg == "CONNECTED")
                    {
                        if (thisClient == "") thisClient = client;
                    }
                    if (autoMode)
                    {
                        if (msg == "DISCONNECTED")
                        {
                            clientData[client] = "";
                        }
                        else if (client.StartsWith("SERVER"))
                        {
                            serverData = msg;
                            bReceived = true;
                        }
                        else
                        {
                            clientData[client] = msg;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// The last server message.
        /// </summary>
        public static Primitive LastServerMessage
        {
            get { return lastServerMessage; }
        }
        /// <summary>
        /// Event when the server sends a message to this client.
        /// </summary>
        public static event SmallBasicCallback ServerMessage
        {
            add { _ServerMessageDelegate = value; }
            remove { _ServerMessageDelegate = null; }
        }
        /// <summary>
        /// Event when server disconnects this client.
        /// </summary>
        public static event SmallBasicCallback Disconnected
        {
            add { _DisconnectedDelegate = value; }
            remove { _DisconnectedDelegate = null; }
        }
    }
}
