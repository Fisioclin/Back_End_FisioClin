using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Util.Email
{
    public class EmailSettings
    {

        public string MailServer { get; set; }
        public int MailPort { get; set; }
        public string SenderName { get; set; }
        public string Sender { get; set; }
        public string Password { get; set; }
        public string Subject { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
        public string Adress { get; set; }
        public bool UseDefaultCredentials { get; set; }
        public bool EnableSSl { get; set; }
    }
}
