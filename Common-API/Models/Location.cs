using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Location
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public long PinCodeId { get; set; }
        public long TehsilId { get; set; }
        public long DistrictId { get; set; }
        public long AreaId { get; set; }
        public long UnitId { get; set; }
        public long ZoneId { get; set; }
        public long WardId { get; set; }
        public long CityId { get; set; }
        public long StateId { get; set; }
        public long CountryId { get; set; }
        public string LocationType { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; }= DateTime.Now;
    }
}
