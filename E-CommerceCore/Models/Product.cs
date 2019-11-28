using System;

namespace ECommerceCore.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public Category Category { get; set; }
    }
}
