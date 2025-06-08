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

        public required string Title { get; set; } = null!;
        public required string Description { get; set; } = null!;
        public required int BrandId { get; set; }
        public required decimal Price { get; set; }
        public required decimal Discount { get; set; }
        public Brand? Brand { get; set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}