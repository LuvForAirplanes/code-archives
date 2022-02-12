using System;
using System.Timers;

namespace MicanetMessageServiceDotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //DailyAlerts.Weather.CheckTime(true);   
            DailyAlerts.Weather.OnStartUp();
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
