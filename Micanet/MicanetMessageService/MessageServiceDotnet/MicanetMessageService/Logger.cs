using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicanetMessageService.Logging
{
    class Logger
    {
        public static string path = "C:\\mmsLOG.txt";
        public static void Log(string message)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                File.AppendAllText(path, DateTime.Now.ToString() + " -- " + message);
            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, DateTime.Now.ToString() + " -- " + message);
            }
        }
    }
}
