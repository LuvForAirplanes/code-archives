using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MicanetMessageService.ContentHandler
{
    class ContentHandler
    {
        public static void HandleContent(string content)
        {
            if (content == "")
            {

            } else if (content.IndexOf("weather") != -1)
            {
                var regExp = @"(?<=[in, at]\s)(\w+)";
                Match micah = Regex.Match(content, regExp);

                Logging.Logger.Log(Email.MonitorEmail.from + " REQUEST: " + content);
                Email.SendEmail.ForwardEmail(Fetchers.Weather.Weather.RetrieveWeather(micah.Groups[0].ToString()));
            } else if(content.IndexOf("subscribe") != -1)
            {
                var mat = Regex.Match(content, @"(?<=subscribe )(\d)+@(\w)+\.(\w)+((\.)(\w)+){0,}");
                Email.MonitorEmail.from = mat.Value.ToString();
                Email.SendEmail.ForwardEmail("Welcome to the Micanet Message Service!");
            } else if((content.IndexOf("stop") != -1) && (content.IndexOf("micahs") != -1) && (content.IndexOf("mac") != -1)) 
            {
                Environment.Exit(0);
            } else if(content.IndexOf("forecast") != -1)
            {
                Logging.Logger.Log(Email.MonitorEmail.from + " REQUEST: " + content);
                Match matchApostrophe = Regex.Match(content, @"(((\w)+)(?='s))");
                Match matchS = Regex.Match(content, @"(((\w)+)(?=s f))");
                Match matchInTown = Regex.Match(content, @"((?<=in )(\w+))");
                Match matchForWeather = Regex.Match(content, @"(((\w)+)(?=s wea))");
                if(matchApostrophe.Value != "")
                {
                    Email.SendEmail.ForwardEmail(Fetchers.Weather.Forecast.GetForecast(matchApostrophe.Value));
                } else if(matchS.Value != "")
                {
                    Email.SendEmail.ForwardEmail(Fetchers.Weather.Forecast.GetForecast(matchS.Value));
                } else if(matchInTown.Value != "")
                {
                    Email.SendEmail.ForwardEmail(Fetchers.Weather.Forecast.GetForecast(matchInTown.Value));
                } else if(matchForWeather.Value != "")
                {
                    Email.SendEmail.ForwardEmail(Fetchers.Weather.Forecast.GetForecast(matchForWeather.Value));
                }
            } else if((content.IndexOf("stop") != -1) && (content.IndexOf("micah") != -1) && (content.IndexOf("devMS@509")) != -1)
            {
                Environment.Exit(0);
            }
        }
    }
}
