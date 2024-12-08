using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Task
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
        public long JobId { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public bool IsDone { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; }= DateTime.Now;
    }
}
