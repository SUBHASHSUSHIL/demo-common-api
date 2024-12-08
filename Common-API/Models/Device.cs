using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Device
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string DeviceCode { get; set; }
        public string SerialNo { get; set; }
        public long DeviceTypeId { get; set; }
        public long MakeId { get; set; }
        public long ModelId { get; set; }
        public long PoleId { get; set; }
        public bool IsActive { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; }= DateTime.Now;
    }
}
