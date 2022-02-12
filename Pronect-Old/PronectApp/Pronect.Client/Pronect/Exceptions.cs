using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronect
{
    /// <summary>
    /// Pronect had an issue logging in to the server.
    /// </summary>
    public class LoginError : Exception
    {
        public LoginError()
        {
        }

        public LoginError(string message) : base(message)
        {
        }

        public LoginError(string message, Exception inner) : base(message, inner)
        {
        }
    }
    /// <summary>
    /// You are attempting to access remote resources and you are not logged in to the directory server.
    /// </summary>
    public class NotLoggedIn : Exception
    {
        public NotLoggedIn()
        {
        }

        public NotLoggedIn(string message) : base(message)
        {
        }

        public NotLoggedIn(string message, Exception inner) : base(message, inner)
        {
        }
    }
    /// <summary>
    /// You are attempting to control the remote computer; however, the session has been closed.
    /// </summary>
    public class SessionClosed : Exception
    {
        public SessionClosed()
        {
        }

        public SessionClosed(string message) : base(message)
        {
        }

        public SessionClosed(string message, Exception inner) : base(message, inner)
        {
        }
    }
    /// <summary>
    /// The server could not be found at the location you specified.
    /// </summary>
    public class ServerNotFound : Exception
    {
        public ServerNotFound()
        {
        }

        public ServerNotFound(string message) : base(message)
        {
        }

        public ServerNotFound(string message, Exception inner) : base(message, inner)
        {
        }
    }
    /// <summary>
    /// The server was not listening on the port number you specified.
    /// </summary>
    public class ServerNotListening : Exception
    {
        public ServerNotListening()
        {
        }

        public ServerNotListening(string message) : base(message)
        {
        }

        public ServerNotListening(string message, Exception inner) : base(message, inner)
        {
        }
    }
    /// <summary>
    /// The remote server forcibly closed the connection.
    /// </summary>
    public class ConnectionForciblyClosed : Exception
    {
        public ConnectionForciblyClosed()
        {
        }

        public ConnectionForciblyClosed(string message) : base(message)
        {
        }

        public ConnectionForciblyClosed(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
