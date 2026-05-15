using _09_Katman.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Katman.DataAccesLayer.Context
{
    public class KampContext:DbContext
    {
        public DbSet<Category> categories  { get; set; }
        public DbSet<Product>  products  { get; set; }
        public DbSet<Order> orders  { get; set; }
        public DbSet<Customer> customers   { get; set; }
        public DbSet<Admin> admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=CSharpKampiDb;Trusted_Connection=True;TrustServerCertificate=True");
        }


    }
}
