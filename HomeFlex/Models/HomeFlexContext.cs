using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeFlex.Models
{
    public class HomeFlexContext: IdentityDbContext<ApplicationUser>
    {
            public HomeFlexContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
           .HasMany(c => c.SubCategories)
           .WithOptional(c => c.ParentCategory)
           .HasForeignKey(c => c.ParentCategoryId);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<Category> Categories { get; set; }

       
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public static HomeFlexContext Create()
            {
                return new HomeFlexContext();
            }
        
    }
}