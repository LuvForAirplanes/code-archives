using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace MicanetMessageServiceDotnetCore.Fetchers.Weather
{
    class Forecast
    {
        public static string key = "d5387128021b1a466192ee485f6c5438";
        public static string GetForecast(string city)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string APIKEY = key;
                string CurrentURL = "http://api.openweathermap.org/data/2.5/forecast?q="
                    + city + "&mode=xml&units=Imperial&APPID=" + APIKEY;
                using (WebClient client = new WebClient())
                {
                    var xmlContent = client.DownloadString(CurrentURL);
                    xmlDocument.LoadXml(xmlContent);
                }
                string returnIfo = "";
                string date = "";

                int setITo = 1;
                int setMax = 1;

                int hour = DateTime.Now.Hour;
                if (hour > 12)
                {
                    setITo = 1;
                    //setMax = 4;
                } else if(hour < 12)
                {
                    setITo = 0;
                    setMax = 3;
                }

                for (int i = setITo; i < setMax; i++)
                {
                    DateTime current = DateTime.Now.AddDays(i);
                    
                    date = current.Year.ToString() + "-" + current.Month.ToString() + "-" + current.Day.ToString();

                    //var matchForDate = Regex.Match(date, @"(\d)+-(\d)-(\d)");
                    //if(matchForDate.Captures.Count != 0)
                    //{
                    //    var matches = Regex.Matches(matchForDate.Value.ToString(), "-(\\d)");
                    //    for (int ii = 0; ii < matches.Count; ii++)
                    //    {
                    //        date.Replace(matches[ii].ToString(), "-0" + matches[ii].ToString());
                    //    }
                    //}

                    XmlNode tempNode = xmlDocument.SelectSingleNode("//forecast//time[@from='" + date + "T12:00:00']//temperature");
                    XmlNode cloudsNode = xmlDocument.SelectSingleNode("//forecast//time[@from='" + date + "T12:00:00']//clouds");
                    XmlNode precipitationNode = xmlDocument.SelectSingleNode("//forecast//time[@from='" + date + "T12:00:00']//precipitation");

                    XmlAttribute minTemp = tempNode.Attributes["min"];
                    XmlAttribute maxTemp = tempNode.Attributes["max"];
                    XmlAttribute clouds = cloudsNode.Attributes["value"];
                    try
                    {
                        XmlAttribute precipitation = precipitationNode.Attributes["name"];
                        XmlAttribute precipitationChance = precipitationNode.Attributes["value"];
                        return current.DayOfWeek.ToString() + " - " + minTemp.Value.ToString() + " - " + maxTemp.Value.ToString() + ", " + clouds.Value.ToString() + ", " + precipitationChance.Value.ToString() + "% of " + precipitation.Value.ToString();
                    }
                    catch
                    {

                    }
                    returnIfo += current.DayOfWeek.ToString() + " - " + minTemp.Value.ToString() + " - " + maxTemp.Value.ToString() + ", " + clouds.Value.ToString() + ", POP 0%; ";

                }
                return returnIfo;
            }
            catch (Exception e)
            {
                if (e.ToString().IndexOf("(404)") != -1)
                {
                    return "The request you sent in couldn't be fulfilled. You may have misspelled the town name.";
                }
                else if (e.ToString().IndexOf("NullReferenceException") != -1)
                {
                    return "Sorry, the server met its grave when you sent that request in; we're not sure what happened, but one of our admin will look at it. :) Thanks!";
                }
                else
                {
                    return e.ToString();
                }
            }
        }
    }
}
