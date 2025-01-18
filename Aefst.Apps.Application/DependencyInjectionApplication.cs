using Microsoft.Extensions.DependencyInjection;

namespace Aefst.Apps.Application
{
    public static class DependencyInjectionApplication
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(DependencyInjectionApplication).Assembly);
            });
            return services;
        }
    }
}
