using Newtonsoft.Json;
using Pronect.UserAccountServer.DbContext.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Pronect.DirectoryServer.Server.Services
{
    public static class AccountServices
    {
        public static UserAccount GetUserAccount(string licenseKey)
        {
            try
            {
                using(var client = new WebClient())
                {
                    string returnString = client.DownloadString("http://localhost:305/api/UserAccounts/" + licenseKey);
                    List<UserAccount> pronectMachine = JsonConvert.DeserializeObject<List<UserAccount>>(returnString);
                    return pronectMachine[0];
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static string GetUserPassword(string licenseKey)
        {
            try
            {
                using (var client = new WebClient())
                {
                    string s = client.DownloadString("http://localhost:305/api/UserAccounts/" + licenseKey);
                    List<UserAccount> pronectMachine = JsonConvert.DeserializeObject<List<UserAccount>>(s);
                    return pronectMachine[0].Password;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void PostUserAccount(string licenseKey, UserAccount newUserAccount)
        {
            try
            {
                var webAddr = "http://localhost:305/api/UserAccounts/";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(newUserAccount);

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

        public static void PutUserAccount(string licenseKey, UserAccount updateUserAccount)
        {
            try
            {
                var webAddr = "http://localhost:305/api/UserAccounts/" + licenseKey;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(updateUserAccount);

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
