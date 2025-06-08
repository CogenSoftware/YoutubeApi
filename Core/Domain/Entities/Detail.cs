using Core.Domain.Common;

namespace Core.Domain.Entities
{
    public class Detail : EntityBase, IEntityBase
    {
        public Detail() { }

        public Detail(string title, string description, int categoryId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
        }

        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}