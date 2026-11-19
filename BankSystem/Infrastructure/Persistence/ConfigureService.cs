using Domain.Abstractions;
using Domain.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence
{
    public static class ConfigureService
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration config)
        {
            /*** MS SQL Server ***/
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(config.GetConnectionString("MSSQL")));

            /*** Unit of Work ***/
            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<DataContext>());

            /*** Repositories ***/
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ICardRepository, CardRepository>();

            return services;
        }
    }
}
