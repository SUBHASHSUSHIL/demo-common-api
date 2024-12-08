using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Alert
    {
        public long Id { get; set; }
        public string AlertNo { get; set; }
        public string Message { get; set; }
        public string MessageType { get; set; }
        public string MediaPath { get; set; }
        public long UnitId { get; set; }
        public long LocationId { get; set; }
        public long DeviceId { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
