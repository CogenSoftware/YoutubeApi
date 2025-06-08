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

        public required string Title { get; set; } = null!;
        public required string Description { get; set; } = null!;
        public required int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}