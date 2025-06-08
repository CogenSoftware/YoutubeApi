using Bogus;
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
                .IsRequired();

            builder.Property(p => p.Discount)
                .IsRequired();

            Faker faker = new("tr");
            Product product1 = new()
            {
                Id = 1,
                BrandId = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Lorem.Paragraph(2),
                Price = decimal.Parse(faker.Commerce.Price()),
                Discount = decimal.Parse(faker.Commerce.Price(0, 100)),
            };
            Product product2 = new()
            {
                Id = 2,
                BrandId = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Lorem.Paragraph(2),
                Price = decimal.Parse(faker.Commerce.Price()),
                Discount = decimal.Parse(faker.Commerce.Price(0, 100)),
            };
            Product product3 = new()
            {
                Id = 3,
                BrandId = 3,
                Title = faker.Commerce.ProductName(),
                Description = faker.Lorem.Paragraph(2),
                Price = decimal.Parse(faker.Commerce.Price()),
                Discount = decimal.Parse(faker.Commerce.Price(0, 100)),
            };
            Product product4 = new()
            {
                Id = 4,
                BrandId = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Lorem.Paragraph(2),
                Price = decimal.Parse(faker.Commerce.Price()),
                Discount = decimal.Parse(faker.Commerce.Price(0, 100)),
            };

            builder.HasData(product1, product2, product3, product4);
        }
    }
}