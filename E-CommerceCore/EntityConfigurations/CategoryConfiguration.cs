using ECommerceCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceCore.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.SubCategories)
                .WithOne(x => x.ParentCategory)
                .HasForeignKey(x => x.ParentId)
                .IsRequired(false);

            //builder.HasMany(x => x.Products)
            //    .WithOne(x => x.Category);

            builder.Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            //var psychoTranceCategory = new Category
            //{
            //    Id = 102,
            //    Name = "PsychoTrance",
            //    ParentId = tranceCategory.Id,
            //};

            builder.HasData(new Category
            {
                Id = 1,
                Name = "Trance",
            });
        }
    }
}
