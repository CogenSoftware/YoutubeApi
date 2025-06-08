using Bogus;
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

            Faker faker = new("tr");

            Category category1 = new()
            {
                Id = 1,
                ParentId = 0,
                Name = faker.Commerce.Categories(1)[0],
                Priority = 1
            };
            Category category2 = new()
            {
                Id = 2,
                ParentId = 0,
                Name = faker.Commerce.Categories(1)[0],
                Priority = 1
            };
            Category category3 = new()
            {
                Id = 3,
                ParentId = 1,
                Name = faker.Commerce.Categories(1)[0],
                Priority = 1
            };
            Category category4 = new()
            {
                Id = 4,
                ParentId = 2,
                Name = faker.Commerce.Categories(1)[0],
                Priority = 1
            };

            builder.HasData(category1, category2, category3, category4);
        }
    }
}