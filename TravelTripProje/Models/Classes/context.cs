using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Classes
{
    public class context : DbContext
    {
        public DbSet<admin> Admins { get; set; }
        public DbSet<addressBlog> AddressBlogs { get; set; }
        public DbSet<blog> Blogs { get; set; }
        public DbSet<about> Abouts { get; set; }
        public DbSet<communication> Communications { get; set; }
        public DbSet<comment> Comments { get; set; }

        
    }
}