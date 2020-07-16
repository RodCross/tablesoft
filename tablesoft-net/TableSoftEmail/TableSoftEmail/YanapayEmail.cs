using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSoftEmail
{
    public class YanapayEmail
    {
        private string fromAddress;
        private string toRecipients;
        private string subject;
        private string body;
        private bool isHtml;

        public YanapayEmail()
        {
        }

        public string FromAddress { get => fromAddress; set => fromAddress = value; }
        public string ToRecipients { get => toRecipients; set => toRecipients = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Body { get => body; set => body = value; }
        public bool IsHtml { get => isHtml; set => isHtml = value; }
    }
}
