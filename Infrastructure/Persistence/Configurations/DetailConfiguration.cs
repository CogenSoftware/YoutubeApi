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

            Detail detail1 = new()
            {
                Id = 1,
                Title = "Detail Title 1",
                Description = "Detail Description 1",
                CategoryId = 1,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Detail detail2 = new()
            {
                Id = 2,
                Title = "Detail Title 2",
                Description = "Detail Description 2",
                CategoryId = 1,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Detail detail3 = new()
            {
                Id = 3,
                Title = "Detail Title 3",
                Description = "Detail Description 3",
                CategoryId = 2,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            Detail detail4 = new()
            {
                Id = 4,
                Title = "Detail Title 4",
                Description = "Detail Description 4",
                CategoryId = 2,
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };

            builder.HasData(detail1, detail2, detail3, detail4);
        }
    }
}