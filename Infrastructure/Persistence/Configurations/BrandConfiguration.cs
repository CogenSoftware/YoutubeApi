using Bogus;
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

            Faker faker = new("tr");

            Brand brand1 = new()
            {
                Id = 1,
                Name = faker.Company.CompanyName()
            };
            Brand brand2 = new()
            {
                Id = 2,
                Name = faker.Company.CompanyName()
            };
            Brand brand3 = new()
            {
                Id = 3,
                Name = faker.Company.CompanyName()
            };

            builder.HasData(brand1, brand2, brand3);
        }
    }
}