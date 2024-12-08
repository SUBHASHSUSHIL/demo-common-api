using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class AlertAssignment
    {
        public long Id { get; set; }
        public long AlertId { get; set; }
        public long UserId { get; set; }
        public string Note { get; set; }
        public bool Impossible { get; set; }
        public bool Closed { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
