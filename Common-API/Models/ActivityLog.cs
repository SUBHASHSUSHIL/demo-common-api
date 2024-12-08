using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class ActivityLog
    {
        public long Id { get; set; }
        public string MasterName { get; set; }
        public long MasterId { get; set; }
        public string UserName { get; set; }
        public string Action { get; set; }
        public string Data { get; set; }
        public string IPAddress { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
