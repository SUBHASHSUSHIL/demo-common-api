using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Event
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EventKey { get; set; }
        public string Data { get; set; }
        public string About { get; set; }
        public long DeviceTypeId { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
