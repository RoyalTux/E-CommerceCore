using System;
using ECommerceCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceCore.EntityConfigurations
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

            builder.HasOne(x => x.Category);

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
                },
                new Product
                {
                    Id = 2,
                    Title = "SHIVA MANTRA VS PSY TRANCE BY SHIVA BLEZE",
                    Album = "Summer Vibes",
                    Artist = "SHIVA BLEZE",
                    Description = "Psy trance music",
                    Genre = "Trance",
                    Price = 6,
                    Quantity = 14,
                    ReleaseDate = DateTime.Now,
                },
                new Product
                {
                    Id = 3,
                    Title = "Trippy Experience | Psychedelic Progressive Psy Trance Mix",
                    Album = "Trippy Experience",
                    Artist = "Electric Samurai",
                    Description = "Psychedelic Progressive",
                    Genre = "Trance",
                    Price = 7,
                    Quantity = 16,
                    ReleaseDate = DateTime.Now,
                });
        }
    }
}
