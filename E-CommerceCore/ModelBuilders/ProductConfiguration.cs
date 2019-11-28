using System;
using ECommerceCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceCore.ModelBuilders
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Genre)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(x => x.Artist)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(x => x.Album)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(x => x.ReleaseDate)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();

            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Title = "Electric Samurai —  Mix Jan 2019",
                    Album = "Summer Vibes",
                    Artist = "Electric Samurai",
                    Description = "Chill music",
                    Genre = "Trance",
                    Price = 5,
                    Quantity = 12,
                    ReleaseDate = DateTime.Now,
                });
        }
    }
}
