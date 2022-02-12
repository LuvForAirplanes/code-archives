using Newtonsoft.Json;
using Pronect.DTOs.StreamData;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Pronect.Connections
{
    static class DirectoryServer
    {
        /// <summary>
        /// The TCP Client that handles the connection to the directory server.
        /// </summary>
        private static TcpClient directoryClient;
        /// <summary>
        /// The data stream that handles directory information.
        /// </summary>
        private static NetworkStream directoryStream;
        /// <summary>
        /// Determines if we are logged in to the directory server.
        /// </summary>
        public static bool IsLoggedIn = false;
        /// <summary>
        /// Opens a connection to the directory server.
        /// </summary>
        /// <param name="openingData"></param>
        /// <returns></returns>
        public static DirectoryReturn Connect(DirectorySend command)
        {
            try
            {
                //pauses the thread for one millisecond to give the socket time to intiate between connections
                Thread.Sleep(1);
                //assigns the client a connection
                directoryClient = new TcpClient(Services.Network.GetLocalIP(), 56372);
                //gets the current stream
                directoryStream = directoryClient.GetStream();
                //write the opening data
                Write(command);
                //sets IsConnected to true
                IsLoggedIn = true;
                return Read();
            }
            catch (Exception e)
            {
                IsLoggedIn = false;
                string exc = e.ToString().ToLower();
                if (exc.IndexOf("no such host") != -1)
                    throw new ServerNotFound ("We could not connect to the Pronect server.");
                else if (exc.IndexOf("actively refused it") != -1)
                    throw new ServerNotListening ("The server was not listening on the specified port.");
                else if (exc.IndexOf("forcibly closed") != -1)
                    throw new ConnectionForciblyClosed ("The server forcibly closed the connection due to an emergency, or wasn't given enough time between connections");
            }
            return new DirectoryReturn();
        }
        /// <summary>
        /// Closes the connection to the directory server.
        /// </summary>
        /// <returns></returns>
        public static void Disconnect()
        {
            try
            {
                directoryStream.Close();
                directoryClient.Close();
                IsLoggedIn = false;
            }
            catch (Exception e)
            {
                string exe = e.ToString().ToUpper();
                if (exe.IndexOf("set to an instance") != 1)
                {
                    throw new SessionClosed("No connection was open to close.");
                }
            }
        }
        /// <summary>
        /// Sends data to the directory server and returns a response.
        /// </summary>
        /// <param name="dataToSend"></param>
        /// <returns></returns>
        public static DirectoryReturn Send(DirectorySend commands)
        {
            var dataToSend = new Byte[1024];
            if (IsLoggedIn)
            {
                Write(commands);
                return Read();
            } else
            {
                throw new NotLoggedIn("You must be logged in to the directory before you can communicate with it.");
            }
        }
        /// <summary>
        /// Writes data to the network stream.
        /// </summary>
        /// <param name="dataToSend"></param>
        public static void Write(DirectorySend commands)
        {
            byte[] dataToSend = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(commands));
            directoryStream.Write(dataToSend, 0, dataToSend.Length);
            directoryStream.Write(Encoding.ASCII.GetBytes("<EOF>"), 0, Encoding.ASCII.GetBytes("<EOF>").Length);
        }
        /// <summary>
        /// Writes data asynchronously to the network stream.
        /// </summary>
        /// <param name="dataToSend"></param>
        /// <returns></returns>
        public static async Task WriteAsync(DirectorySend commands)
        {
            byte[] dataToSend = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(commands));
            await directoryStream.WriteAsync(dataToSend, 0, dataToSend.Length);
            await directoryStream.WriteAsync(Encoding.ASCII.GetBytes("<EOF>"), 0, Encoding.ASCII.GetBytes("<EOF>").Length);
        }
        /// <summary>
        /// Reads data from the network stream and returns the result.
        /// </summary>
        /// <returns></returns>
        public static DirectoryReturn Read()
        {
            //creates an empty megabyte
            Byte[] bytes = new Byte[1024];
            string stringedBytes = "";
            //capture the data in a memory stream
            using (var memoryStream = new MemoryStream())
            {
                //declare our incrementer
                int i;
                //loop to receive all the data
                while((i = directoryStream.Read(bytes, 0, bytes.Length)) > 0)
                {
                    string stringData = Encoding.ASCII.GetString(bytes, 0, i);
                    memoryStream.Write(bytes, 0, bytes.Length);
                    bytes = new Byte[1024];
                    if (stringData.EndsWith("<EOF>"))
                        break;
                }
                stringedBytes = Regex.Match(Encoding.ASCII.GetString(memoryStream.ToArray()), ".+?(?=<EOF>)").Value;
            }
            return JsonConvert.DeserializeObject<DirectoryReturn>(stringedBytes);
        }
        /// <summary>
        /// Reads data from the network stream asynchronously; it then handles it.
        /// </summary>
        /// <returns></returns>
        public static async Task ReadAsync()
        {
            //creates an empty megabyte
            Byte[] bytes = new Byte[1024];
            string stringedBytes = "";
            //capture the data in a memory stream
            using (var memoryStream = new MemoryStream())
            {
                //declare our incrementer
                int i;
                //loop to receive all the data
                while ((i = await directoryStream.ReadAsync(bytes, 0, bytes.Length)) > 0)
                {
                    string stringData = Encoding.ASCII.GetString(bytes, 0, i);
                    await memoryStream.WriteAsync(bytes, 0, bytes.Length);
                    bytes = new Byte[1024];
                    if (stringData.EndsWith("<EOF>"))
                        break;
                }

                stringedBytes = Regex.Match(Encoding.ASCII.GetString(memoryStream.ToArray()), ".+?(?=<EOF>)").Value;
            }

            DirectoryReturn returns = JsonConvert.DeserializeObject<DirectoryReturn>(stringedBytes);
        }
        /// <summary>
        /// Sets the Connection servers info based off the directory's response.
        /// </summary>
        public static void SetClientInfo()
        {
            GetClientInfo();
        }
        private static void GetClientInfo()
        {
            DirectoryReturn result = Send(new DirectorySend() { Commands = new System.Collections.Generic.List<Command>() { new Command() { Name = "abl" } } });
            //match the ip from the return string and assign it to Ip
            ConnectionServer.ConnectionIp = result.CommandReturns.ReturnData[0];
            //match the port number from the return string and assign it to Port
            ConnectionServer.ConnectionPort = result.CommandReturns.ReturnData[1];
            //Matches the connection pin for the connection server
            ConnectionServer.ConnectionPin = result.CommandReturns.ReturnData[2];
        }
    }
}
