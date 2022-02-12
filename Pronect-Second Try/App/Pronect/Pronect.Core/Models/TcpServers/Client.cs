using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Pronect.Models.TcpServers
{
    /// <summary>
    /// Communicate with the remote machine.
    /// </summary>
    public class Client
    {
        public IPAddress IPAddress { get; set; }
        public int Port { get; set; }

        private TcpClient client;
        private NetworkStream stream;

        public void Connect()
        {
            try
            {
                client = new TcpClient(IPAddress.ToString(), Port);
                stream = client.GetStream();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Disconnect()
        {
            try
            {
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                string exe = e.ToString().ToUpper();
                if (exe.IndexOf("set to an instance") != 1)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void Write(byte[] commands)
        {
            stream.Write(commands, 0, commands.Length);
        }

        public async Task WriteAsync(byte[] commands)
        {
            await stream.WriteAsync(commands, 0, commands.Length);
        }

        public byte[] Read()
        {
            var bytes = new byte[1024];
            stream.Read(bytes, 0, bytes.Length);
            return bytes;
        }

        public async Task<byte[]> ReadAsync()
        {
            var bytes = new byte[1024];
            await stream.ReadAsync(bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
