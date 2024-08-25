using Blog.Entity.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.DTOs.Articles
{
    public class ArticleSafeDeleteDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = true;
    }
}
