using Newtonsoft.Json;
using Pronect.DTOs.StreamData;
using Pronect.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using static Pronect.ScreenCapture;

namespace Pronect.Connections
{
    static class ConnectionServer
    {
        /// <summary>
        /// The TCP Client that manages the conenction to the connection sever.
        /// </summary>
        private static TcpClient connectionClient;
        /// <summary>
        /// The stream that manages the data communicated to and from the connection server.
        /// </summary>
        private static NetworkStream connectionStream;
        /// <summary>
        /// Determines if we are logged in to the connection server.
        /// </summary>
        public static bool IsSignedIn = false;
        /// <summary>
        /// The Ip at which the connection server is located.
        /// </summary>
        public static string ConnectionIp;
        /// <summary>
        /// The port at which the connection sever is listening on.
        /// </summary>
        public static string ConnectionPort;
        /// <summary>
        /// The conenction pin to provide autho for the connection server.
        /// </summary>
        public static string ConnectionPin;
        /// <summary>
        /// Whether the current cycle returned.
        /// </summary>
        public static bool CycleReturn = true;
        /// <summary>
        /// A list of commands to be sent to the remote machine.
        /// </summary>
        public static List<Command> Commands = new List<Command>();
        public static List<Command> ServerCommands = new List<Command>();
        /// <summary>
        /// Opens a connection to the connection server.
        /// </summary>
        /// <param name="openingData"></param>
        /// <returns></returns>
        public static ConnectionReturn Connect(ConnectionSend connectionSend)
        {
            try
            {
                //pauses the thread for one millisecond to give the socket time to intiate between connections
                Thread.Sleep(1);
                //assigns the client a connection
                connectionClient = new TcpClient(Services.Network.GetLocalIP(), Int32.Parse(ConnectionPort));
                //gets the current stream
                connectionStream = connectionClient.GetStream();
                //writes an openening message to the server
                Write(connectionSend);
                IsSignedIn = true;
                StartCycles();
                return Read();
            }
            catch (Exception e)
            {
                string exc = e.ToString().ToLower();
                if (exc.IndexOf("no such host") != -1)
                    throw new ServerNotFound("We could not connect to the Pronect server.");
                else if (exc.IndexOf("actively refused it") != -1)
                    throw new ServerNotListening("The server was not listening on the specified port.");
                else if (exc.IndexOf("forcibly closed") != -1)
                    throw new ConnectionForciblyClosed("The server forcibly closed the connection due to an emergency, or wasn't given enough time between connections");
            }
            return null;
        }
        /// <summary>
        /// close connection to connection server.
        /// </summary>
        /// <returns></returns>
        public static void Disconnect()
        {
            try
            {
                StopCycles();
                connectionStream.Close();
                connectionClient.Close();
                IsSignedIn = false;
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
        /// Sends data to the connection server. WILL POSSIBLY BY DEPRICATED!!! Attach data to cycle instead!
        /// </summary>
        /// <param name="dataToSend"></param>
        /// <returns></returns>
        public static ConnectionReturn Send(ConnectionSend connectionSend)
        {
            Write(connectionSend);
            return Read();
        }
        /// <summary>
        /// Writes data to the network stream.
        /// </summary>
        /// <param name="dataToSend"></param>
        public static void Write(ConnectionSend connectionSend)
        {
            var dataToSend = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(connectionSend));
            connectionStream.Write(dataToSend, 0, dataToSend.Length);
            connectionStream.Write(Encoding.ASCII.GetBytes("<EOF>"), 0, Encoding.ASCII.GetBytes("<EOF>").Length);
        }
        /// <summary>
        /// Writes data asynchronously to the network stream.
        /// </summary>
        /// <param name="dataToSend"></param>
        /// <returns></returns>
        public static async Task WriteAsync(ConnectionSend connectionSend)
        {
            var dataToSend = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(connectionSend));
            await connectionStream.WriteAsync(dataToSend, 0, dataToSend.Length);
            await connectionStream.WriteAsync(Encoding.ASCII.GetBytes("<EOF>"), 0, Encoding.ASCII.GetBytes("<EOF>").Length);
        }
        /// <summary>
        /// Reads data from the network stream and returns the result.
        /// </summary>
        /// <returns></returns>
        public static ConnectionReturn Read()
        {
            byte[] bytes = new Byte[1024];
            string stringedBytes = "";
            using(var memoryStream = new MemoryStream())
            {
                int i;
                while((i = connectionStream.Read(bytes, 0, bytes.Length)) > 0)
                {
                    string stringData = Encoding.ASCII.GetString(bytes, 0, i);
                    memoryStream.Write(bytes, 0, bytes.Length);
                    bytes = new byte[1024];
                    if (stringData.EndsWith("<EOF>"))
                        break;
                }
                stringedBytes = Regex.Match(Encoding.ASCII.GetString(memoryStream.ToArray()), ".+?(?=<EOF>)").Value;
            }
            return JsonConvert.DeserializeObject<ConnectionReturn>(stringedBytes);
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
                while ((i = await connectionStream.ReadAsync(bytes, 0, bytes.Length)) > 0)
                {
                    string stringData = Encoding.ASCII.GetString(bytes, 0, i);
                    await memoryStream.WriteAsync(bytes, 0, bytes.Length);
                    bytes = new Byte[1024];
                    if (stringData.EndsWith("<EOF>"))
                        break;
                }

                stringedBytes = Regex.Match(Encoding.ASCII.GetString(memoryStream.ToArray()), ".+?(?=<EOF>)").Value;
            }

            ConnectionReturn returns = JsonConvert.DeserializeObject<ConnectionReturn>(stringedBytes);

            //response gets handled here
            if(returns.CommandResults.ReturnData[0].Contains(""))
            {

            }
        }
        /// <summary>
        /// Sends the cycle data for one cycle to the conenction server.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private static void SendCycleData(object source, ElapsedEventArgs e)
        {
            ScreenCapture screenCapture = new ScreenCapture();
            ConnectionSend command = new ConnectionSend()
            {
                Commands = Commands,
                ServerCommands = ServerCommands,
                Desktop = Conversion.GetBytesFromImage(screenCapture.CaptureWindow(User32.GetDesktopWindow()))
            };
            if(CycleReturn)
                 Write(command);

            ServerCommands = new List<Command>();
        }
        static System.Timers.Timer interval;
        /// <summary>
        /// Start the timer which sends the Cycle Data.
        /// </summary>
        private static void StartCycles()
        {
            interval = new System.Timers.Timer(3000);
            interval.Elapsed += new System.Timers.ElapsedEventHandler(SendCycleData);
            interval.Start();
        }
        /// <summary>
        /// Stops the timer which sends the Cycle Data.
        /// </summary>
        private static void StopCycles()
        {
            interval.Stop();
        }
    }
}
