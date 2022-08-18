using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryEF.DataContext;
using RepositoryEF.Repositories;

namespace RepositoryEF
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MySQL");
            services.AddDbContext<ProductDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
