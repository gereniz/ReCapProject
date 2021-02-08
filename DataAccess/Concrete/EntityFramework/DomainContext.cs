using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class DomainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=ReCapProjectDatabase;User ID=postgres;Password=Gg030912051996*;");
        }

        public DbSet<Car> car { get; set; }
        public DbSet<Brand> brand { get; set; }
        public DbSet<Color> color { get; set; }

    }
}
