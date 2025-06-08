using Core.Domain.Common;

namespace Core.Domain.Entities
{
    public class Category : EntityBase, IEntityBase
    {
        public Category() { }

        public Category(int parentId, string name, int priority)
        {
            ParentId = parentId;
            Name = name;
            Priority = priority;
        }

        public required int ParentId { get; set; }
        public required string Name { get; set; } = null!;
        public required int Priority { get; set; }
        public ICollection<Detail> Details { get; set; } = new List<Detail>();
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}