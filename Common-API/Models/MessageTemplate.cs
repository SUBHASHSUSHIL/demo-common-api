using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class MessageTemplate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public string SMS { get; set; }
        public bool WhatsappStatus { get; set; }
        public bool EmailStatus { get; set; }
        public bool SMSStatus { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
