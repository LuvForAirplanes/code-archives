using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MicanetMessageService.Email
{
    class SendEmail
    {
        public static void ForwardEmail(string message)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("micanetmessageservice@gmail.com");
            msg.To.Add(MonitorEmail.from);
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
