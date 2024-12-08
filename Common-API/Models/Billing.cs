using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Billing
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Regdate { get; set; }= DateTime.Now;
        public bool IsPaid { get; set; }

    }
}
