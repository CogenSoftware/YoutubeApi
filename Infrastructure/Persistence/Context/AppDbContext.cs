using System.Reflection;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Detail> Details { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}