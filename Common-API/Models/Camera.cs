using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Camera
    {
        public long Id { get; set; }
        public string IPAddress { get; set; }
        public decimal Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LiveURL { get; set; }
        public long DeviceId { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
