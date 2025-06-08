using Core.Domain.Common;

namespace Core.Domain.Entities
{
    public class Product : EntityBase, IEntityBase
    {
        public Product() { }

        public Product(string title, string description, int brandId, decimal price)
        {
            Title = title;
            Description = description;
            BrandId = brandId;
            Price = price;
        }

        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Brand? Brand { get; set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}