using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Vehicle
    {
        public long Id { get; set; }
        public string VehicleNumber { get; set; }
        public long VehicleTypeId { get; set; }
        public long VehicleCategoryId { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; }= DateTime.Now;
    }
}
