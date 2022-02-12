using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MicanetServer
{
    class ErrorReporter
    {
        public static string sentFrom = "";
        public static List<string> contacts = new List<string>();

        public static string SendSMS(string errorMsg)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("micanetproject@gmail.com");
            foreach (var contact in contacts)
            {
                msg.To.Add(contact);
            }
            msg.Subject = "";
            msg.Body = errorMsg;
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("micanetproject@gmail.com", "micanet@gmail");
            client.Timeout = 20000;
            client.Send(msg);
            return "";
        }
    }
}
