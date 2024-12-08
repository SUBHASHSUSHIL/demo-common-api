using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class UserPermission
    {
        public long Id { get; set; }
        public long MenuId { get; set; }
        public long UserId { get; set; }
        public bool PView { get; set; }
        public bool PAdd { get; set; }
        public bool PEdit { get; set; }
        public bool PDelete { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
