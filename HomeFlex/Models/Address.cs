using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeFlex.Models
{
    public class Address
    {
        //public int Id { get; set; }
        //public string FName { get; set; }
        public String LName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string AppUserId { get; set; }
        public ApplicationUser AppUser { get; set; }
    }
}