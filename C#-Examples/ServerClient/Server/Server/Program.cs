using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server - by Micah Stauffer (https://github.com/LuvForAirplanes/)");

            Server.Start();

            while (true) {
                Console.WriteLine(Encoding.ASCII.GetString(Server.Read()));
                Server.Write(Encoding.ASCII.GetBytes("The message has been received."));
            }
        }
    }
}
