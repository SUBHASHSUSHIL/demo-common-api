using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Unit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string Logo { get; set; }
        public string PAN { get; set; }
        public string ConcernPerson { get; set; }
        public string Mobile { get; set; }
        public string GST { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; }= DateTime.Now;
    }
}
