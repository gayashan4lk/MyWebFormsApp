using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyWebFormsApp.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("MyWebFormsApp")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}