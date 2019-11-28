using System.Collections.Generic;

namespace ECommerceCore.Models
{
    public class Category
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public virtual Category ParentCategory { get; set; }

        public string Name { get; set; }

        public ICollection<Category> SubCategories { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
