using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MicanetBrowser
{
    class Connect
    {

        public static void ConnectToRelay(String message)
        {
            try
            {
                TcpClient client = new TcpClient("192.168.1.2", 56374);
                Byte[] data = Encoding.ASCII.GetBytes(message);

                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                data = new Byte[1024];

                String responseData = String.Empty;

                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.ASCII.GetString(data, 0, bytes);
                if (responseData == "404")
                {
                    //MainWindow.write("404 Not Found");
                    //MainWindow.write(MainWindow.GetLocalContent(@"C:\Program Files (x86)\Micanet\MicanetBrowser\0.0.0.5\pages\notfound.html"));
                }
                else
                {
                    //MainWindow.write(responseData);
                }
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {// MainWindow.write(e.ToString()); }
            }
            catch (SocketException e)
            { //MainWindow.write(e.ToString()); }
            }
        }
    }
}
