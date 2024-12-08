using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Media
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string MediaPath { get; set; }
        public string MediaType { get; set; }
        public string ModuleName { get; set; }
        public long MasterId { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
