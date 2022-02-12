using Newtonsoft.Json;
using Pronect.DirectoryServer.DbContext.Models;
using Pronect.DirectoryServer.Server.Services;
using Pronect.DirectoryServer.Server.DTOs;
using Pronect.UserAccountServer.DbContext.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.DirectoryServer.Server
{
    public class ResponseHandler
    {
        private UserAccount currentUserAccount = new UserAccount();
        private PronectDevice currentDevice = new PronectDevice();

        public byte[] Login(DirectorySend directorySend)
        {
            currentUserAccount = AccountServices.GetUserAccount(directorySend.Commands[0].Parameters[0]);

            byte[] data = null;
            //checks if the passwords match
            if (currentUserAccount.Password == directorySend.Commands[0].Parameters[1])
            {
                data = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new DirectoryReturn() { CommandReturns = new ReturnCommand() { ReturnData = new List<string>() { Services.NetworkServices.GetLocalIP(), "56372", "5678413927" } } }));
            }
            return data;
        }

        public byte[] Logout(string Account, string Password)
        {
            Console.WriteLine("Logged Out");
            return Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new DirectoryReturn() { CommandReturns = new ReturnCommand() { ReturnData = new List<string>() { "200" } } }));
        }

        public byte[] Signin(DirectorySend directorySend)
        {
            var a = directorySend.Commands[0].Parameters[0];
            currentDevice = DeviceServices.GetDevice(a);
            currentDevice.SignedIn = true;
            DeviceServices.PutDevice(currentDevice.Id, currentDevice);
            return Encoding.ASCII.GetBytes("signed in");
        }

        public byte[] Signout(DirectorySend directorySend)
        {
            var a = directorySend.Commands[0].Parameters[0];
            var device = DeviceServices.GetDevice(a);
            device.SignedIn = false;
            DeviceServices.PutDevice(device.Id, device);
            return Encoding.ASCII.GetBytes("signed out");
        }
    }
}
