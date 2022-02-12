using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MicanetMessageServiceDotnetCore.Email
{
    class SendEmail
    {
        public static void ForwardEmail(string message, string sender)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("micanetmessageservice@gmail.com");
            msg.To.Add(sender);
            msg.Subject = "";
            msg.Body = message;
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("micanetmessageservice@gmail.com", "mms@gmail");
            client.Timeout = 20000;
            client.Send(msg);
        }
    }
}
