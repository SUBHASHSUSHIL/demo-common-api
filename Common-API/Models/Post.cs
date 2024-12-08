using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Models
{
    public class Post
    {
        public long Id { get; set; }
        public long PostTemplateId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string About { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
        public int ViewOrder { get; set; }
        public string ImagePath { get; set; }
        public string PostType { get; set; }
        public bool Status { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
