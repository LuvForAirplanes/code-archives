using Pronect.Connections;
using Pronect.DTOs.StreamData;
using Pronect.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect
{
    public class PronectSession
    {
        /// <summary>
        /// Determines if you are connected to your partner.
        /// </summary>
        bool IsconnectedToPartner = false;
        /// <summary>
        /// Control and monitor the remote machine.
        /// </summary>
        public RemoteMachine RemoteMachine = new RemoteMachine();
        /// <summary>
        /// The Id of the remote machine you are connecting to.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The current Pronect password of the remote machine you are connecting to.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// The display resolution the remote machines screen should be returned in from left to right.
        /// </summary>
        public int ReturnResolutionX { get; set; }
        /// <summary>
        /// The display resolution the remote machines screen should be returned in from top to bottom.
        /// </summary>
        public int ReturnResolutionY { get; set; }

        //All this stuff is old code: It really needs to be updated.
        /// <summary>
        /// Initiates a new Pronect session using the Id and Password props.
        /// </summary>
        public void Connect()
        {
            if ((string.IsNullOrWhiteSpace(ConnectionServer.ConnectionPort)) || (string.IsNullOrWhiteSpace(ConnectionServer.ConnectionIp)))
                throw new NotLoggedIn("You must Login in and set client data before opening a connection.");

            if ((Id == null) || Password == null)
                throw new ArgumentNullException("The Id and Password must be set to initiate a Pronect session.");
            
            ConnectionServer.ServerCommands.Add(new Command() { Name = "abi", Parameters = new List<string>() { Id, Password } });
            IsconnectedToPartner = true;
        }
        /// <summary>
        /// Disconnects from the current session.
        /// </summary>
        public void Disconnect()
        {
            if(IsconnectedToPartner)
            {
                ConnectionServer.ServerCommands = new List<Command>() { new Command() { Name = "abj", Parameters = new List<string>() { Id } } };
            } else
            {
                throw new SessionClosed("Session is already closed!");
            }
        }
        /// <summary>
        /// Opens a new desktop connection on the current session.
        /// </summary>
        public void OpenDesktopControl()
        {

        }
        /// <summary>
        /// Starts an audio call on the current session.
        /// </summary>
        public void OpenAudioCall()
        {

        }
        /// <summary>
        /// Opens a video call on the current connection.
        /// </summary>
        public void OpenVideoCall()
        {

        }
    }
}
