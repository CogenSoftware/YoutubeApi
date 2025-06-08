using Bogus;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder.Property(d => d.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(d => d.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(d => d.CategoryId)
                .IsRequired();

            builder.HasOne(d => d.Category)
                .WithMany(c => c.Details)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            Faker faker = new("tr");
            Detail detail1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(3),
                Description = faker.Lorem.Paragraph(2),
                CategoryId = 1
            };
            Detail detail2 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(3),
                Description = faker.Lorem.Paragraph(2),
                CategoryId = 1
            };
            Detail detail3 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(3),
                Description = faker.Lorem.Paragraph(2),
                CategoryId = 2
            };
            Detail detail4 = new()
            {
                Id = 4,
                Title = faker.Lorem.Sentence(3),
                Description = faker.Lorem.Paragraph(2),
                CategoryId = 2
            };

            builder.HasData(detail1, detail2, detail3, detail4);
        }
    }
}