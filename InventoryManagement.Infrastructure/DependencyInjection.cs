

using InventoryManagement.Application.Commons.Interfaces.Authentication;
using InventoryManagement.Application.Commons.Interfaces.Services;
using InventoryManagement.Infrastructure.Authentication;
using InventoryManagement.Infrastructure.Services;
using InventoryManagement.Infraustructure.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
         this IServiceCollection services, ConfigurationManager configuration)
        {
            // Settings
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            // Singleton Services: AuthSerices
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDataTimeProvider, DatetimeProvider>();

            return services;
        }
    }
}
