using Newtonsoft.Json;
using Pronect.DirectoryServer.Server.Services;
using Pronect.DirectoryServer.Server.DTOs;
using Pronect.UserAccountServer.DbContext.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Pronect.DirectoryServer.Server
{
    public class RawHandler
    {
        public byte[] ProcessRawBytes(byte[] data)
        {
            var responseHandler = new ResponseHandler();

            //set image box to the output of CreateBitmap which is a BitmapImage
            var directorySend = JsonConvert.DeserializeObject<DirectorySend>(Encoding.ASCII.GetString(data));
            if (directorySend == null)
                return null;
            foreach (Command command in directorySend.Commands)
            {
                switch (command.Name)
                {
                    case "aaa":
                        break;
                    case "aab":
                        break;
                    case "aac":
                        break;
                    case "aad":
                        break;
                    case "aae":
                        break;
                    case "aaf":
                        break;
                    case "aag":
                        break;
                    case "aah":
                        break;
                    case "aaj":
                        break;
                    case "aak":
                        break;
                    case "aal":
                        break;
                    case "aam":
                        break;
                    case "aan":
                        break;
                    case "aao":
                        break;
                    case "aap":
                        break;
                    case "aaq":
                        break;
                    case "aar":
                        break;
                    case "aas":
                        break;
                    case "aat":
                        break;
                    case "aau":
                        break;
                    case "aav":
                        break;
                    case "aaw":
                        break;
                    case "aax":
                        break;
                    case "aay":
                        break;
                    case "aaz":
                        break;
                    case "aba":
                        break;
                    case "abb":
                        break;
                    case "abc":
                        break;
                        //directory server logout
                    case "abd":
                        return responseHandler.Logout("", "");
                    case "abe":
                        break;
                    case "abf":
                        break;
                    case "abg":
                        break;
                    case "abh":
                        break;
                    case "abj":
                        break;
                        //directory server login
                    case "abk":
                        return responseHandler.Login(directorySend);
                        //get connection server info
                    case "abl":
                        return Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new DirectoryReturn() { CommandReturns = new ReturnCommand() { ReturnData = new List<string>() { NetworkServices.GetLocalIP(), "56373", "5678413927" } } }));
                        //accept incoming connections
                    case "abm":
                        break;
                        //signin a pronect device
                    case "abn":
                        responseHandler.Signin(directorySend);
                        break;
                        //signout a pronect device
                    case "abo":
                        responseHandler.Signout(directorySend);
                        break;
                    default:
                        break;
                }
            }
            return Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new DirectoryReturn() { CommandReturns = new ReturnCommand() { ReturnData = new List<string>() { "404" } } }));
        }
    }
}
