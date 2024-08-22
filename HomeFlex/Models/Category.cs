using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeFlex.Models
{
    public class Category:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Photo { get; set; }

        public string FilePath { get; set; }
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; }
    }
}