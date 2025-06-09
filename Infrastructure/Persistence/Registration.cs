using Core.Application.Interfaces.Repositories;
using Core.Application.Interfaces.UnitOfWorks;
using Core.Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence
{
    public static class Registration
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddIdentityCore<User>(option =>
            {
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequiredLength = 2;
                option.Password.RequireLowercase = false;
                option.Password.RequireUppercase = false;
                option.Password.RequireDigit = false;
                option.SignIn.RequireConfirmedEmail = false;
            }).AddRoles<Role>().AddEntityFrameworkStores<AppDbContext>();

            return services;
        }
    }
}