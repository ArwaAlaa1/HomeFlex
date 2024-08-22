using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeFlex.Models
{
    public class ProductPhoto:BaseEntity
    {
        public string Photo { get; set; }
        public string FilePath { get; set; }
        public Product Product { get; set; }

        public int ProductId { get; set; }
    }
}