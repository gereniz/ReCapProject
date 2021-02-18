using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class DomainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=ReCapProjectDatabase;User ID=postgres;Password=Gg030912051996* ;");//   *******
        }

        public DbSet<Cars> cars { get; set; }
        public DbSet<Brands> brands { get; set; }
        public DbSet<Colors> colors { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Rentals> rentals { get; set; }


    }
}
