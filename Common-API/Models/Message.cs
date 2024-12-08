using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Message
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Messages { get; set; }
        public string MessageType { get; set; }
        public string AlertNo { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; }= DateTime.Now;
    }
}
