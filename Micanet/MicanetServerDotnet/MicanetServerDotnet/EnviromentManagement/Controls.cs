using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicanetServerDotnet.EnviromentManagement
{
    class Controls
    {
        public static void Restart()
        {
            var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
            System.Diagnostics.Process.Start(info);
            Stop();
        }

        public static void Stop()
        {
            Environment.Exit(0);
        }
    }
}
