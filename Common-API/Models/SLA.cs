using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class SLA
    {
        public long Id { get; set; }
        public string UserLevel { get; set; }
        public string AlertSeverity { get; set; }
        public string AfterTime { get; set; }
        public long MessageTemplateId { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
