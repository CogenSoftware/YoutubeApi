using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(b => b.Name)
                 .IsRequired()
                 .HasMaxLength(100);

            Brand brand1 = new()
            {
                Id = 1,
                Name = "Toyota",
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Brand brand2 = new()
            {
                Id = 2,
                Name = "Ford",
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Brand brand3 = new()
            {
                Id = 3,
                Name = "Honda",
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };

            builder.HasData(brand1, brand2, brand3);
        }
    }
}