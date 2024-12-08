﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class TaskInfo
    {
        public long Id { get; set; }
        public long TaskId { get; set; }
        public long QuestionId { get; set; }
        public string Answer { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
