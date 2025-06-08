using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.Property(c => c.ParentId)
                .IsRequired();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Priority)
            .IsRequired();

            Category category1 = new()
            {
                Id = 1,
                ParentId = 0,
                Name = "Electronics",
                Priority = 1,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Category category2 = new()
            {
                Id = 2,
                ParentId = 0,
                Name = "Fashion",
                Priority = 1,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Category category3 = new()
            {
                Id = 3,
                ParentId = 1,
                Name = "Smartphones",
                Priority = 1,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Category category4 = new()
            {
                Id = 4,
                ParentId = 2,
                Name = "Men's Fashion",
                Priority = 1,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };

            builder.HasData(category1, category2, category3, category4);
        }
    }
}