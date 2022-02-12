using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.ConnectionServer.Services
{
    public static class ErrorHandling
    {
        public static void HandleError(Exception e)
        {
            Email.SendEmail(e.Message.ToString(), "Pronect Connection Server");
        }
    }
}
