using System.Net;
using System.Net.Sockets;
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

        public static async Task Start()
        {
            //assign the server its job with a TcpListener with our port and ip handed in
            server = new TcpListener(IPAddress, Port);
            //start the server
            server.Start();
            client = await server.AcceptTcpClientAsync();
            stream = client.GetStream();
            var ipEndpoint = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
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
    }
}
