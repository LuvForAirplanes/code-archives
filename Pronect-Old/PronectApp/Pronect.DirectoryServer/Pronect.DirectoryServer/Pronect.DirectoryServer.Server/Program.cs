using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace Pronect.DirectoryServer.Server
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Pronect Directory Server 1.0.0.0 - © 2018 by Pronect Software");
            StartNewHandler();
        }

        static void StartNewHandler()
        {
            Thread t = new Thread(new ThreadStart(ConnectToClients));
            t.Start();
        }

        public static void ConnectToClients()
        {
            var handler = new RawHandler();

            //set server to nothing
            TcpListener server = null;
            //create connection port
            Int32 port = Int32.Parse("56372");
            //create connection ip
            IPAddress localAddr = IPAddress.Parse(Services.NetworkServices.GetLocalIP());
            Console.WriteLine(Services.NetworkServices.GetLocalIP());
            //assign the server its job with a TcpListener with our port and ip handed in
            server = new TcpListener(localAddr, port);
            //starts the server
            server.Start();
            //accepts tcp clients
            TcpClient client = server.AcceptTcpClient();
            //gets the stream of bytes from the network stream
            NetworkStream stream = client.GetStream();
            //try to receive and parse the data
            Console.WriteLine(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
            try
            {
                while (true)
                {
                    //sets the return data to null
                    string data = null;
                    //capture byte data
                    using (var memory = new MemoryStream())
                    {
                        //creates an empty megabyte
                        Byte[] bytes = new Byte[1024];
                        //declare our incrementer
                        int i;
                        // Loop to receive all the data sent by the client.
                        while ((i = stream.Read(bytes, 0, bytes.Length)) > 0)
                        {
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                            memory.Write(bytes, 0, bytes.Length);
                            bytes = new Byte[1024];
                            if (data.EndsWith("<EOF>"))
                                break;
                        }
                        //get the actual data
                        var stringFromBytes = Encoding.ASCII.GetString(memory.ToArray());
                        //trim off the extra data :)
                        stringFromBytes = Regex.Match(stringFromBytes, ".+?(?=<EOF>)").Value;
                        //handle the response
                        byte[] msg = handler.ProcessRawBytes(Encoding.ASCII.GetBytes(stringFromBytes));

                        if (msg == null)
                            break;
                        // Send back a response
                        stream.Write(@msg, 0, msg.Length);
                        stream.Write(Encoding.ASCII.GetBytes("<EOF>"), 0, Encoding.ASCII.GetBytes("<EOF>").Length);
                    }
                }
            }
            //catch any errors
            catch (Exception e)
            {
                //report the errors
                Console.WriteLine(e);
            }
            server.Stop();
            //close the client
            client.Close();
            //start a new handler to handle additional connections
            StartNewHandler();
        }
    }
}
