using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Question
    {
        public long Id { get; set; }
        public string QuestionText { get; set; }
        public long GroupId { get; set; }
        public string QuestionType { get; set; }
        public long UserId { get; set; }
        public int ViewOrder { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
