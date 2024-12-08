using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class DeviceHealth
    {
        public long Id { get; set; }
        public long DeviceId { get; set; }
        public bool VoltageStatus { get; set; }
        public bool PingStatus { get; set; }
        public bool DataStatus { get; set; }
        public bool DataStayStatus { get; set; }
        public bool BatteryDischargeStatus { get; set; }
        public long TotalScore { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; }= DateTime.Now;
    }
}
