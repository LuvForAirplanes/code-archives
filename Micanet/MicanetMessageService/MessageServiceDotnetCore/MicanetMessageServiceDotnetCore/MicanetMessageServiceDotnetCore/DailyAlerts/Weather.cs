using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MicanetMessageServiceDotnetCore.DailyAlerts
{
    class Weather
    {
        public static void OnStartUp()
        {
            CheckTime();
            StartTimer();
        }

        public static void StartTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 3600000;
            aTimer.Start();
        }

        public static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            CheckTime();
        }

        public static void CheckTime(bool send = false)
        {
            int hour = DateTime.Now.Hour;
            if (hour == 7)
            {
                Email.SendEmail.ForwardEmail(Fetchers.Weather.Forecast.GetForecast("myerstown"), "7178215700@txt.att.net");
            } else if(send)
            {
                Email.SendEmail.ForwardEmail(Fetchers.Weather.Forecast.GetForecast("myerstown"), "7178215700@txt.att.net");
            }
        }
    }
}
