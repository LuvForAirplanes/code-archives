using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace MicanetServer.Logging
{
    class Logger
    {
        public static void LogActivity(Exception msg)
        {
            string path = @"C:\Program Files (x86)\Micanet\ContentServer\log.json";
            if (!File.Exists(path))
            {
                File.Create(path);
                File.AppendAllText(path, DateTime.Now.ToString() + " - MESSAGE: " + msg.Message + " INNER EXCEPTION(S): " + msg.InnerException
                + " STACK TRACE: " + msg.StackTrace + " TARGET SITE: " + msg.TargetSite + Environment.NewLine);
            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, DateTime.Now.ToString() + " - MESSAGE: " + msg.Message + " INNER EXCEPTION(S): " + msg.InnerException
                    + " STACK TRACE: " + msg.StackTrace + " TARGET SITE: " + msg.TargetSite + Environment.NewLine);
            }
        }
        
        public static void SocketError(SocketException e)
        {
            ErrorHandler.SocketError(e);
            LogActivity(e);
        }

        public static void FileNotFound(FileNotFoundException e)
        {
            ErrorHandler.FileNotFound(e);
            LogActivity(e);
        }
    }
}
