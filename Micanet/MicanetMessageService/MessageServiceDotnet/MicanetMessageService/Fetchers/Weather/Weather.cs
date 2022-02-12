using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MicanetMessageService.Fetchers.Weather
{
    class Weather
    {
        private static string key = "68490c03698fceac1b7b2c661d6c70db";
        public static string RetrieveWeather(string city)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string APIKEY = key;
                string CurrentURL = "http://api.openweathermap.org/data/2.5/weather?q="
                    + city + "&mode=xml&units=Imperial&APPID=" + APIKEY;
                using (WebClient client = new WebClient())
                {
                    var xmlContent = client.DownloadString(CurrentURL);
                    xmlDocument.LoadXml(xmlContent);
                }
                XmlNode tempn = xmlDocument.SelectSingleNode("//temperature");
                XmlNode humidityNode = xmlDocument.SelectSingleNode("//humidity");
                XmlNode windNameNode = xmlDocument.SelectSingleNode("//wind//speed");
                XmlNode lastNode = xmlDocument.SelectSingleNode("//lastupdate");

                XmlAttribute tempv = tempn.Attributes["value"];
                XmlAttribute last = lastNode.Attributes["value"];
                XmlAttribute windName = windNameNode.Attributes["name"];
                XmlAttribute humidity = humidityNode.Attributes["value"];
                XmlAttribute windSpeed = windNameNode.Attributes["value"];
                

                return "In " + city + " it was " + tempv.Value + "°F, a " + windName.Value.ToLower() + " is blowing at about " + windSpeed.Value + " mph, and the humidity is about " + humidity.Value + "% -- " + last.Value;
            } catch (Exception e)
            {
                if(e.ToString().IndexOf("(404)") != -1)
                {
                    return "The request you sent in couldn't be fulfilled. You may have misspelled the town name.";
                } else
                {
                    return e.ToString();
                }
            }
            return "";
        }
    }
}
