using Core.Domain.Common;

namespace Core.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category() { }

        public Category(int parentId, string name, int priority)
        {
            ParentId = parentId;
            Name = name;
            Priority = priority;
        }

        public int ParentId { get; set; }
        public string Name { get; set; } = null!;
        public int Priority { get; set; }
        public ICollection<Detail> Details { get; set; } = new List<Detail>();
        public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    }
}