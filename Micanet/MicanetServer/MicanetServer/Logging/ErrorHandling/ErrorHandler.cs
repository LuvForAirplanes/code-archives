using System;
using System.Net.Sockets;
using System.IO;

namespace MicanetServer
{
    class ErrorHandler
    {
        public static void SocketError(SocketException e)
        {
            ErrorReporter.SendSMS(e.ToString());
        }

        public static void FileNotFound(FileNotFoundException e)
        {
            ErrorReporter.SendSMS("The file was not found");
        }
    }
}
