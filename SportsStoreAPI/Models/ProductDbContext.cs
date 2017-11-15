using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SportsStoreAPI.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("SportsStoreDb")
        {
            Database.SetInitializer<ProductDbContext>(new ProductDbInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}