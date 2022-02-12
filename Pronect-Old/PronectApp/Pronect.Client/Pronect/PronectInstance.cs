using Newtonsoft.Json;
using Pronect.Connections;
using Pronect.DTOs.StreamData;
using Pronect.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;
using static Pronect.ScreenCapture;

namespace Pronect
{
    public static class PronectInstance
    {
        public static bool AcceptIncomingConnections
        {
            get
            {
                return acceptIncomingConnections;
            }
            set
            {
                if (value)
                {
                    StartIncomingConnections();
                acceptIncomingConnections = value;
                }
                else
                    StartIncomingConnections();
                acceptIncomingConnections = value;
            }
        }
        static bool acceptIncomingConnections = false;
        /// <summary>
        /// Start accepting incoming connections from the directory server.
        /// </summary>
        static void StartIncomingConnections()
        {
            if (DirectoryServer.IsLoggedIn == true)
            {
                DirectoryServer.Send(new DirectorySend() { Commands = new List<Command>() { new Command() { Name = "abm", Parameters = new List<string>() { "true" } } } });
            }
            else
            {
                throw new ArgumentException("", "You must be connected to the directory server before you can start incoming conenctions.");
            }
        }
        /// <summary>
        /// Stop accepting incoming connections from the directory server.
        /// </summary>
        static void StopIncomingConnections()
        {
            DirectoryServer.Send(new DirectorySend() { Commands = new List<Command>() { new Command() { Name = "abm", Parameters = new List<string>() { "false" } } } });
            AcceptIncomingConnections = false;
        }
        /// <summary>
        /// Logs in the directory server.
        /// </summary>
        /// <param name="LicenseKey"></param>
        /// <param name="AccountPassword"></param>
        public static void Login(string LicenseKey, string AccountPassword)
        {
            if(!DirectoryServer.IsLoggedIn)
            {
                if (string.IsNullOrEmpty(LicenseKey) || string.IsNullOrEmpty(AccountPassword))
                    throw new ArgumentNullException("", "AccountUser and AccountPassword must be set to Login to the server.");
                DirectoryServer.Connect(new DirectorySend() { Commands = new List<Command>() { new Command() { Name = "abk", Parameters = new List<string>() { LicenseKey, AccountPassword } } } });
                DirectoryServer.IsLoggedIn = true;
            } else
            {
                throw new LoginError("Already logged in.");
            }
        }
        /// <summary>
        /// Closes the connection to the directory server.
        /// </summary>
        public static void Logout()
        {
            DirectoryServer.Send(new DirectorySend() { Commands = new List<Command>() { new Command() { Name = "abd" } } });
            DirectoryServer.Disconnect();
        }
        /// <summary>
        /// Signs your current device in and connects to the connection server.
        /// </summary>
        /// <param name="deviceId"></param>
        public static void Signin(string deviceId)
        {
            var response = DirectoryServer.Send(new DirectorySend() { Commands = new List<Command>() { new Command() { Name = "abn", Parameters = new List<string>() { deviceId } } } });
            if (response.CommandReturns.ReturnData[0].Contains("unauthorized"))
            {
                throw new LoginError("Incorrect logout credentials.");
            }
            DirectoryServer.SetClientInfo();
            ConnectToConnectionServer(ConnectionServer.ConnectionPin);
        }
        /// <summary>
        /// Signs your current device out and disconnects from the connection server.
        /// </summary>
        /// <param name="deviceId"></param>
        public static void Signout(string deviceId)
        {
            var response = DirectoryServer.Send(new DirectorySend() { Commands = new List<Command>() { new Command() { Name = "abo", Parameters = new List<string>() { deviceId } } } });
            ConnectionServer.Disconnect();
            if (response.CommandReturns.ReturnData[0].Contains("unauthorized"))
            {
                throw new LoginError("Incorrect logout credentials.");
            }
        }
        /// <summary>
        /// Make a connection to the connection server.
        /// </summary>
        /// <param name="pin"></param>
        public static void ConnectToConnectionServer(string pin)
        {
            if (!ConnectionServer.IsSignedIn)
            {
                ConnectionServer.Connect(new ConnectionSend() { ServerCommands = new List<Command>() { new Command() { Name = "abp", Parameters = new List<string>() { pin } } } });
            }
            if (ConnectionServer.IsSignedIn)
            {
                ConnectionServer.Commands.Add(new Command() { Name = "abi", Parameters = new List<string>() { "589458323", "g7df34" } });
            }
        }
        /// <summary>
        /// Disconnect from the connection server.
        /// </summary>
        public static void DisconnectFromConnectionServer()
        {
            ConnectionServer.Disconnect();
        }
    }
}
