using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
namespace Task1
{
    public class MyDatabase : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Error> Errors { get; set; }

        public MyDatabase()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasAlternateKey(ord => new { ord.Name, ord.OrderAlterId });
            modelBuilder.Ignore<Error>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CustomizingEntitiesDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
