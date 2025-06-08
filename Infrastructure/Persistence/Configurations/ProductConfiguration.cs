using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(p => p.BrandId)
                .IsRequired();

            builder.Property(p => p.Price)
                .IsRequired()
                .HasPrecision(18, 4);

            builder.Property(p => p.Discount)
                .IsRequired()
                .HasPrecision(5, 2);

            Product product1 = new()
            {
                Id = 1,
                BrandId = 1,
                Title = "Product Title 1",
                Description = "Product Description 1",
                Price = 100,
                Discount = 10,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Product product2 = new()
            {
                Id = 2,
                BrandId = 2,
                Title = "Product Title 2",
                Description = "Product Description 2",
                Price = 200,
                Discount = 20,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Product product3 = new()
            {
                Id = 3,
                BrandId = 3,
                Title = "Product Title 3",
                Description = "Product Description 3",
                Price = 300,
                Discount = 30,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Product product4 = new()
            {
                Id = 4,
                BrandId = 1,
                Title = "Product Title 4",
                Description = "Product Description 4",
                Price = 400,
                Discount = 40,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };

            builder.HasData(product1, product2, product3, product4);
        }
    }
}