using ECommerceCore.ModelBuilders;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
