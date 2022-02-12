using System;
using System.Net;
using System.Net.Mail;

namespace Pronect.Services
{
    class ErrorHandling
    {
        /// <summary>
        /// Handles a Pronect error.
        /// </summary>
        /// <param name="e"></param>
        public static void HandleError(Exception e)
        {
            ByEmail(e.ToString(), "Amos");
        }
        /// <summary>
        /// Sends a message to the specified email address.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="from"></param>
        public static void ByEmail(string message, string from)
        {
            MailMessage msg = new MailMessage
            {
                From = new MailAddress("micanetproject@gmail.com")
            };
            msg.To.Add("micah@abcrun.com");
            msg.Subject = "Error from Pronect";
            msg.Body = "This error is from: " + from + " Error: " + message;
            SmtpClient client = new SmtpClient
            {
                UseDefaultCredentials = true,
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("micanetproject@gmail.com", "micanet@gmail"),
                Timeout = 20000
            };
            client.Send(msg);
        }
    }
}
