using CelilCavus.WebApi.Configuration;
using CelilCavus.WebApi.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.WebApi.Context
{
    public class ETicaretContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          

            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreWebApi_ETicaret;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}