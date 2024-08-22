using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeFlex.Models
{
    public class Product:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Details { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

     
        //public string CompanyId { get; set; }
    }
}