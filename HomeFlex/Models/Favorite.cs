using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeFlex.Models
{
    public class Favorite
    {
        [Key, Column(Order = 0)]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}