using Core.Domain.Common;

namespace Core.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product() { }

        public Product(string title, string description, int brandId, decimal price, decimal discount)
        {
            Title = title;
            Description = description;
            BrandId = brandId;
            Price = price;
            Discount = discount;
        }

        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Brand? Brand { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    }
}