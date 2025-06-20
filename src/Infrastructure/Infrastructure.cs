using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddMapster();

            return services;
        }
    }
}