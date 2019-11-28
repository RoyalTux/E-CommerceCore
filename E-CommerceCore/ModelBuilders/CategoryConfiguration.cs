using ECommerceCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceCore.ModelBuilders
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

            builder.Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            var tranceCategory = new Category
            {
                Id = 101,
                Name = "Trance",
            };

            //var psychoTranceCategory = new Category
            //{
            //    Id = 102,
            //    Name = "PsychoTrance",
            //    ParentId = tranceCategory.Id,
            //};

            builder.HasData(new
            {
                Id = 1,
                Name = "Trance",
            });
        }
    }
}
