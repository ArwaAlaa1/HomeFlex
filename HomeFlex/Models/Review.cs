using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeFlex.Models
{
    public class Review:BaseEntity
    {
        public string Comment { get; set; }
        public double Rating { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ApplicationUser User { get; set; }
        public int UserId { get; set; }
    }
}