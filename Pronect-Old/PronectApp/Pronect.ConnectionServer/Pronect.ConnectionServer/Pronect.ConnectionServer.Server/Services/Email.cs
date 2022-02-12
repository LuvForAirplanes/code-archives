using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Pronect.ConnectionServer.Services
{
    class Email
    {
        public static void SendEmail(string message, string from)
        {
            throw new ArgumentException("");
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
