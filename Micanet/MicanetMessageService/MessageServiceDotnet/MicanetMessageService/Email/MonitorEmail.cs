using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicanetMessageService.Email
{
    class MonitorEmail
    {
        public static string from = "";
        public static void GetEmail()
        {
            try
            {
                var client = new ImapX.ImapClient("smtp.gmail.com", 993, true);
                client.Connect();
                client.Login("micanetmessageservice@gmail.com", "mms@gmail");
                var messages = client.Folders["INBOX"].Search("ALL");
                string msg = messages[0].Body.Text;
                from = messages[0].From.Address;

                if(msg.IndexOf("no!") != -1)
                {

                } else
                {
                    messages[0].Remove();
                }
                ContentHandler.ContentHandler.HandleContent(msg.ToLower());
            }
            catch
            {

            }
        }
    }
}
