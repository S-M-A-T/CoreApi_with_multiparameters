using System.ComponentModel.DataAnnotations;

namespace TestCoreApi2.Models
{
    public class Product
    {
        // Unique identifier for the product
        public int Id { get; set; }

        // Name of the product
        public string Name { get; set; }

        // Category to which the product belongs
        public string Category { get; set; }

        // Price of the product with decimal type
        public decimal Price { get; set; }
    }
}
