using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MicanetMessageService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Micanet Message Service - Micah Stauffer 2017");
            Email.MonitorEmail.GetEmail();

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 20000;
            aTimer.Start();
            Console.ReadLine();
        }

        public static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Email.MonitorEmail.GetEmail();
        }
    }
}
