using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.RecordServer.DbContext.Models
{
    public class ConnectionRecord
    {
        /// <summary>
        /// The Id used to identify this particular session.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The connection id of the device making the connection.
        /// </summary>
        public string HostConnectionId { get; set; }
        /// <summary>
        /// The connection id of the remote device being administered to.
        /// </summary>
        public string RemoteConnectionId { get; set; }
        /// <summary>
        /// The time the connection was started. Shown as: [month][day][year][hour][minute][second]
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// The time the connection ended. Shown as: [month][day][year][hour][minute][second]
        /// </summary>
        public string EndTime { get; set; }
    }
}
