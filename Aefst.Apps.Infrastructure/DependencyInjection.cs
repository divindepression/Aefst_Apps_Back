using Aefst.Apps.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Aefst.Apps.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) 
        {
            services.AddScoped<IAdresseRepository, IAdresseRepository>();
            return services;
        }
    }
}
