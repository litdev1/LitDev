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

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace LitDev
{
    public class Client
    {
        public string name;
        public TcpClient tcpClient;
        public bool connected = false;
        private NetworkStream networkStream;
        private byte[] bytes;
        private string[] messages;

        public Client(string name, TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            this.name = name;
            networkStream = tcpClient.GetStream();
            connected = true;
            Thread thread = new Thread(new ThreadStart(Listen));
            thread.Start();
        }
        private void Listen()
        {
            string[] separators = new string[] { "\0" };
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
                                LDServer.ClientMessageDelegate(name, message);
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
    }

    /// <summary>
    /// Server and Client communication between computers.
    /// Separate programs are required for the server and client - this is for the server.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDServer
    {
        private static IPAddress _ip = IPAddress.None;
        private static int _port = 100;
        private static TcpListener tcpListener = null;
        private static TcpClient tcpServer = null;
        private static IPAddress ip
        {
            get
            {
                if (_ip == IPAddress.None)
                {
                    List<IPAddress> ipList = new List<IPAddress>();
                    foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                    {
                        if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                        {
                            foreach (UnicastIPAddressInformation ua in ni.GetIPProperties().UnicastAddresses)
                            {
                                if (ua.Address.AddressFamily == AddressFamily.InterNetwork)
                                {
                                    ipList.Add(ua.Address);
                                }
                            }
                        }
                    }
                    if (ipList.Count == 0) return IPAddress.None;
                    _ip = ipList[0];
                }
                return _ip;
            }
            set
            {
                _ip = value;
            }
        }
        private static bool listening = false;
        private static bool autoMode = true;
        private static bool autoMessages = true;
        private static int numCLient = 0;
        private static int closeDelay = 100;
        private static object lockSend = new object();
        private static object lockListen = new object();
        private static List<Client> clients = new List<Client>();
        private static Primitive serverData = "";

        public static string lastClient = "";
        public static string lastClientConnected = "";
        public static string lastClientDisconnected = "";
        public static string lastClientMessage = "";
        public static SBCallback _ClientMessageDelegate = null;
        private static SBCallback _ClientConnectedDelegate = null;
        private static SBCallback _ClientDisconnectedDelegate = null;

        private static Client GetClient(EndPoint endPoint)
        {
            foreach (Client client in clients)
            {
                if (client.tcpClient.Client.LocalEndPoint.ToString() == endPoint.ToString())
                {
                    return client;
                }
            }
            return null;
        }

        private static Client GetClient(string name)
        {
            foreach (Client client in clients)
            {
                if (client.name == name)
                {
                    return client;
                }
            }
            return null;
        }

        private static Client RemoveClient(string name)
        {
            Client client = GetClient(name);
            if (null != client)
            {
                clients.Remove(client);
                client.connected = false;
                serverData[name] = "";
            }
            return null;
        }

        private static string NextClient()
        {
            return "Client" + (++numCLient);
        }

        private static void Listen()
        {
            while (listening)
            {
                try
                {
                    tcpServer = tcpListener.AcceptTcpClient();
                    //Test connection is still alive after a short delay (LDCient.CheckServer)
                    Thread.Sleep(100);
                    byte[] buffer = new byte[1] { 0 }; //A single 0 has no action on client
                    tcpServer.Client.Send(buffer);

                    Client client = new Client(NextClient(), tcpServer);
                    clients.Add(client);
                    lastClientConnected = client.name;
                    if (null != _ClientConnectedDelegate) _ClientConnectedDelegate();
                    if (autoMode)
                    {
                        if (autoMessages) TextWindow.WriteLine(client.name + " Connected");
                        if (serverData != "") SendMessage(client.name, "SERVER:" + serverData);
                    }
                    for (int i = 0; i < clients.Count; i++) //Possible use case for Broadcast()
                    {
                        SendMessage(clients[i].name, client.name + ":CONNECTED");
                    }
                }
                catch
                {
                }
            }
            if (null != tcpServer) tcpServer.Close();
            if (null != tcpListener) tcpListener.Stop();
            tcpServer = null;
            tcpListener = null;
        }

        private static void MonitorClients()
        {
            while (listening)
            {
                foreach (Client client in clients)
                {
                    if (!client.tcpClient.Connected)
                    {
                        ClientMessageDelegate(client.name, "DISCONNECT");
                        break;
                    }
                }
                Thread.Sleep(100);
            }
        }

        private static string Send(string clientName, string message)
        {
            lock (lockSend)
            {
                Client client = GetClient(clientName);
                if (null == client) return "NO_CLIENT";
                if (!client.tcpClient.Connected) return "NOT_CONNECTED";
                Byte[] bytes = Encoding.UTF8.GetBytes(message + '\0');
                NetworkStream networkStream = client.tcpClient.GetStream();
                networkStream.Write(bytes, 0, bytes.Length);
                return "SUCCESS";
            }
        }

        /// <summary>
        /// The IP address of the server (it is defaulted to the current LAN IP).
        /// If you want to use over the internet, then a web IP will be needed.
        /// </summary>
        public static Primitive IP
        {
            get
            {
                return ip.ToString();
            }
            set
            {
                try
                {
                    ip = IPAddress.Parse(value);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// The windows port to use (default 100).
        /// </summary>
        public static Primitive Port
        {
            get { return _port; }
            set { _port = value; }
        }

        /// <summary>
        /// A delay in ms (default 100) when disconnecting to allow a message to be sent before connection closed (Stop, Disconnect and Close).
        /// This delay should also be set for clients in LDClient.CloseDelay.
        /// </summary>
        public static Primitive CloseDelay
        {
            get { return closeDelay; }
            set { closeDelay = value; }
        }

        /// <summary>
        /// Show TextWindow connection messages when in auto mode "True" (default) or "False".
        /// </summary>
        public static Primitive AutoMessages
        {
            get { return autoMessages ? "True" : "False"; }
            set { autoMessages =  value; }
        }

        /// <summary>
        /// Disconnect a client.
        /// </summary>
        /// <param name="clientName">The client name, usually Client1, Client2 etc.
        /// A list of current clients can be obtained from the method GetClients or found from the ClientConnected event.</param>
        /// <returns>"SUCCESS", "NOT_CONNECTED", "NO_CLIENT" or "FAILED"</returns>
        public static Primitive Disconnect(Primitive clientName)
        {
            try
            {
                string result = Send(clientName, "DISCONNECT");
                Thread.Sleep(CloseDelay);
                RemoveClient(clientName);
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Disconnect and close (End) a client.
        /// </summary>
        /// <param name="clientName">The client name, usually Client1, Client2 etc.
        /// A list of current clients can be obtained from the method GetClients or found from the ClientConnected event.</param>
        /// <returns>"SUCCESS", "NOT_CONNECTED", "NO_CLIENT" or "FAILED"</returns>
        public static Primitive Close(Primitive clientName)
        {
            try
            {
                string result = Send(clientName, "CLOSE");
                Thread.Sleep(CloseDelay);
                RemoveClient(clientName);
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Send a message to a client.
        /// </summary>
        /// <param name="clientName">The client name, usually Client1, Client2 etc.
        /// A list of current clients can be obtained from the method GetClients or found from the ClientConnected event.</param>
        /// <param name="message">The message may be any variable including an array.</param>
        /// <returns>"SUCCESS", "NOT_CONNECTED", "NO_CLIENT" or "FAILED"</returns>
        public static Primitive SendMessage(Primitive clientName, Primitive message)
        {
            try
            {
                return Send(clientName, message);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

		/// <summary>
		/// Send a message to all clients.
		/// </summary>
		/// <param name="message">The message may be any variable including an array.</param>
		/// <returns>A array of values "SUCCESS", "NOT_CONNECTED", "NO_CLIENT" or "FAILED" with the Client Name being the index.</returns>
		public static Primitive Broadcast(Primitive message)
		{
			StringBuilder result = new StringBuilder(); //Used for performance reasons. Immutable vs mutable and all that.
			for (int i = 0; i < clients.Count; i++)
			{
				string status = SendMessage(clients[i].name, message);
				result.Append( Utilities.ArrayParse(clients[i].name) + "=" + status + ";" );
			}
			return Utilities.CreateArrayMap(result.ToString());
		}

        /// <summary>
        /// Start the server.
        /// </summary>
        /// <param name="auto">Enable auto message passing "True" or "False".
        /// If this is used (recommended) then all client data is passed via server to all other clients, 
        /// and no processing of send and receive events is required.
        /// The data is updated to arrays of data (indexed by client name) that is returned from the client Update methods.
        /// The auto option should be the same for server and all clients.</param>
        /// <returns>The current connection parameter ip:port (e.g. "192.168.1.60:100"), or "FAILED".
        /// This is the parameter to use to connect from the client.</returns>
        public static Primitive Start(Primitive auto)
        {
            try
            {
                Stop();
                autoMode = auto;
                tcpListener = new TcpListener(ip, _port);
                tcpListener.Start();
                listening = true;
                Thread thread = new Thread(new ThreadStart(Listen));
                thread.Start();
                thread = new Thread(new ThreadStart(MonitorClients));
                thread.Start();
                return IP+":"+Port;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get a list of current connected clients.
        /// </summary>
        /// <returns>An array of current client names or "" for none.</returns>
        public static Primitive GetClients()
        {
            string result = "";
            for (int i = 0; i < clients.Count; i++)
            {
                result += (i + 1).ToString() + "=" + Utilities.ArrayParse(clients[i].name) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Stop the current server and close all clients.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED"</returns>
        public static Primitive Stop()
        {
            try
            {
                for (int i = 0; i < clients.Count; i++)
                {
                    Send(clients[i].name, "CLOSE");
                    Thread.Sleep(CloseDelay);
                    clients[i].connected = false;
                }
                listening = false;
                clients.Clear();
                serverData = "";
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        [HideFromIntellisense]
        public static void ClientMessageDelegate(string client,string message)
        {
            lock (lockListen)
            {
                if (message.StartsWith("INTERNAL:"))
                {
                    message = message.Substring(9);
                    if (message.StartsWith("NAME:"))
                    {
                        string newName = message.Substring(5);
                        GetClient(client).name = newName;
                        serverData[newName] = serverData[client];
                        serverData[client] = "";
                    }
                    else if (message.StartsWith("CLIENTS:"))
                    {
                        SendMessage(client, "INTERNAL:CLIENTS:" + GetClients());
                    }
                }
                else if (message == "DISCONNECT")
                {
                    lastClientDisconnected = client;
                    if (null != _ClientDisconnectedDelegate) _ClientDisconnectedDelegate();
                    RemoveClient(client);
                    if (autoMode)
                    {
                        serverData[client] = "";
                        if (autoMessages) TextWindow.WriteLine(client + " Disconnected");
						for (int i = 0; i < clients.Count; i++) //Possible use case for Broadcast()
                        {
                            SendMessage(clients[i].name, client + ":DISCONNECTED");
                        }
                    }
                }
                else
                {
                    lastClient = client;
                    lastClientMessage = message;
                    if (null != _ClientMessageDelegate) _ClientMessageDelegate();
                    if (autoMode)
                    {
                        if (message.EndsWith(":"))
                        {
                            serverData[client] = message.Substring(0, message.Length - 1);
                            SendMessage(client, "SERVER:" + serverData);
                        }
                        else
                        {
                            for (int i = 0; i < clients.Count; i++) //Possible use case for Broadcast()
                            {
                                if (client != clients[i].name) SendMessage(clients[i].name, client + ":" + message);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// The last client name.
        /// </summary>
        public static Primitive LastClient
        {
            get { return lastClient; }
        }
        /// <summary>
        /// The last client connected name.
        /// </summary>
        public static Primitive LastClientConnected
        {
            get { return lastClientConnected; }
        }
        /// <summary>
        /// The last client disconnected name.
        /// </summary>
        public static Primitive LastClientDisconnected
        {
            get { return lastClientDisconnected; }
        }
        /// <summary>
        /// The last client message.
        /// </summary>
        public static Primitive LastClientMessage
        {
            get { return lastClientMessage; }
        }
        /// <summary>
        /// Event when a client sends a message to the server.
        /// </summary>
        public static event SBCallback ClientMessage
        {
            add { _ClientMessageDelegate = value; }
            remove { _ClientMessageDelegate = null; }
        }
        /// <summary>
        /// Event when a client connects.
        /// </summary>
        public static event SBCallback ClientConnected
        {
            add { _ClientConnectedDelegate = value; }
            remove { _ClientConnectedDelegate = null; }
        }
        /// <summary>
        /// Event when a client disconnects.
        /// </summary>
        public static event SBCallback ClientDisconnected
        {
            add { _ClientDisconnectedDelegate = value; }
            remove { _ClientDisconnectedDelegate = null; }
        }
    }
}
