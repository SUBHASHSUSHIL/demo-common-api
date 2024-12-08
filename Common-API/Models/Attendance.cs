using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Attendance
    {
        public long Id { get; set; }
        public long UsersId { get; set; }
        public long ShiftId { get; set; }
        public string AttendanceStatus { get; set; } // (Assuming varchar(1) can be 'P' for Present, 'A' for Absent, etc.)
        public string Remark { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
