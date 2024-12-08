using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Route
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int RouteNo { get; set; }
        public string About { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int AverageTime { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
