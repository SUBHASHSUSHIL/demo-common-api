﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class UserJob
    {
        public long Id { get; set; }
        public long JobId { get; set; }
        public long UserId { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
