using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class FloodTransaction
    {
        public long Id { get; set; }
        public long DeviceId { get; set; }
        public string Imei { get; set; }
        public string Mac { get; set; }
        public int FloodValue { get; set; }
        public int Date { get; set; }
        public int Time { get; set; }
        public DateTime RegDate { get; set; }= DateTime.Now;
    }
}
