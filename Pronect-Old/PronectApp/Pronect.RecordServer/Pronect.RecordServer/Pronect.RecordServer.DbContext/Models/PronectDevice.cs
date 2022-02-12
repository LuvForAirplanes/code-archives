using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.DirectoryServer.DbContext.Models
{
    public class PronectDevice
    {
        /// <summary>
        /// The Id of the machine.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The email address or license key this is machine is licensed under.
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// The friendly name of this machine.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The password used for unattended access.
        /// </summary>
        public string PermanentPassword { get; set; }
        /// <summary>
        /// An ever changing password used for quick support and remote access.
        /// </summary>
        public string TempPassword { get; set; }
    }
}
