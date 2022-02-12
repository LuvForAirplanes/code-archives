using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.UserAccountServer.DbContext.Models
{
    public class UserAccount
    {
        /// <summary>
        /// The id of the user account.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The license key of this user account. If it is a personal account, an email address is used. 
        /// </summary>
        public string LicenseKey { get; set; }
        /// <summary>
        /// The password for this Pronect account.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// The date this user account was acquired.
        /// </summary>
        public string DateAcquired { get; set; }
        /// <summary>
        /// The owner that created this user account.
        /// </summary>
        public string OwnersName { get; set; }
        /// <summary>
        /// The devices this account is linked to.
        /// </summary>
        public string Devices { get; set; }
        /// <summary>
        /// A list of devices (device id's) this account watches.
        /// </summary>
        public string WatchedDevices { get; set; }
    }
}
