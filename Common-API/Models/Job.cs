using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Job
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
        public string WorkType { get; set; }
        public string JobType { get; set; }
        public string JobCategory { get; set; }
        public string JobManagedBy { get; set; }
        public string RevenueManagedBy { get; set; }
        public long DepartmentId { get; set; }
        public long OrganizationId { get; set; }
        public long ManagerId { get; set; }
        public DateTime JobDate { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
