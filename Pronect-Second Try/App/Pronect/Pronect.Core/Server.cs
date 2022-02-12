using Newtonsoft.Json;
using Pronect.Core;
using Pronect.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pronect
{
    /// <summary>
    /// Accepts incoming connections.
    /// </summary>
    public static class Server
    {
        public static IPAddress IPAddress { get; set; }
        public static int Port { get; set; }

        public static TcpListener server = null;
        public static TcpClient client = null;
        public static NetworkStream stream = null;

        public static TcpSend DataToSend { get; set; } = new TcpSend();

        public static Timer SendDataTimer { get; set; }

        public static async Task Start()
        {
            //assign the server its job with a TcpListener with our port and ip handed in
            server = new TcpListener(IPAddress, Port);
            //start the server
            server.Start();
            client = await server.AcceptTcpClientAsync();
            stream = client.GetStream();
            var ipEndpoint = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

            SendDataTimer  = new Timer(Send, null, 1000, Timeout.Infinite);

            await ReadAsync();
        }

        private static void Send(object state)
        {
            if(DataToSend.Commands.Count != 0)
            {
                Write(Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(DataToSend)));
                DataToSend.Commands = new List<TcpCommand>();
            }
        }

        public static void Stop()
        {
            //stop the server
            server.Stop();
            //close the client
            client.Close();
        }

        public static byte[] Read()
        {
            var bytes = new byte[1024];
            stream.Read(bytes, 0, bytes.Length);
            return bytes;
        }

        public static async Task<byte[]> ReadAsync()
        {
            var bytes = new byte[1024];
            await stream.ReadAsync(bytes, 0, bytes.Length);
            HandleResult(bytes);
            return bytes;
        }

        public static void Write(byte[] data)
        {
            stream.Write(data, 0, data.Length);
        }

        public static async Task WriteAsync(byte[] data)
        {
            await stream.WriteAsync(data, 0, data.Length);
        }

        public static async Task HandleResult(byte[] bytes)
        {
            ResponseHandler.IncomingBytes(bytes);
        }
    }
}
