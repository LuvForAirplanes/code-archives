using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MicanetMessageServiceDotnetCore.ContentHandler
{
    class ContentHandler
    {
        public static void HandleContent(string content, string reply)
        {
            if (content == "")
            {

            }
            else if (content.IndexOf("weather") != -1)
            {
                var regExp = @"(?<=[in, at]\s)(\w+)";
                Match micah = Regex.Match(content, regExp);

                Logger.Log(Email.MonitorEmail.from + " REQUEST: " + content);
                Email.SendEmail.ForwardEmail(Fetchers.Weather.Weather.RetrieveWeather(micah.Groups[0].ToString()), reply);
            }
            else if (content.IndexOf("subscribe") != -1)
            {
                var mat = Regex.Match(content, @"(?<=subscribe )(\d)+@(\w)+\.(\w)+((\.)(\w)+){0,}");
                Email.MonitorEmail.from = mat.Value.ToString();
                Email.SendEmail.ForwardEmail("Welcome to the Micanet Message Service!", reply);
            }
            //&& (content.IndexOf("micahs") != -1) && (content.IndexOf("mac") != -1)
            else if ((content.IndexOf("stop") != -1))
            {
                Environment.Exit(0);
            }
            else if (content.IndexOf("forecast") != -1)
            {
                Logger.Log(Email.MonitorEmail.from + " REQUEST: " + content);
                Match matchApostrophe = Regex.Match(content, @"((((\w)+)(?='s))|(((\w)+)(?=s f))|((?<=in )(\w+))|(((\w)+)(?=s wea)))");
                if (matchApostrophe.Value != "")
                {
                    Email.SendEmail.ForwardEmail(Fetchers.Weather.Forecast.GetForecast(matchApostrophe.Value), reply);
                }
            }
            else if ((content.IndexOf("stop") != -1) && (content.IndexOf("micah") != -1) && (content.IndexOf("devMS@509")) != -1)
            {
                Environment.Exit(0);
            }
        }
    }
}
