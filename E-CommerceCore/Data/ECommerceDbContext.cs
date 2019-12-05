using ECommerceCore.EntityConfigurations;
using ECommerceCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceCore.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext (DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
