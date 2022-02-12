using Newtonsoft.Json;
using Pronect.DirectoryServer.DbContext.Models;
using Pronect.UserAccountServer.DbContext.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Pronect.DirectoryServer.Server.Services
{
    class DeviceServices
    {
        public static PronectDevice GetDevice(string id)
        {
            try
            {
                using (var client = new WebClient())
                {
                    string returnString = client.DownloadString("http://localhost:303/api/Devices/" + id);
                    List<PronectDevice> device = JsonConvert.DeserializeObject<List<PronectDevice>>(returnString);
                    return device[0];
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void PostDevice(string id, PronectDevice newDevice)
        {
            try
            {
                var webAddr = "http://localhost:303/api/Devices/";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(newDevice);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void PutDevice(string id, PronectDevice updatedDevice)
        {
            try
            {
                var webAddr = "http://localhost:303/api/Devices/" + id;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(updatedDevice);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
