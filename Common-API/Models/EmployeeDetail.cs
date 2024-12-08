using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class EmployeeDetail
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string EMPCode { get; set; }
        public DateTime DOJ { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string PAN { get; set; }
        public string Adhaar { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
