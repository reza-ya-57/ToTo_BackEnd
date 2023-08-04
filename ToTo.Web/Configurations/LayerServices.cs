using ToTo.Application.Configurations;
using ToTo.Domain.Configurations;
using ToTo.Infrastructure.Configurations;


namespace ToTo.Web.Configurations
{
    public static class LayerServices
    {
        public static IServiceCollection AddLayerServices(this IServiceCollection services)
        {
            services.AddInsfrastructureServices();
            services.AddApplicationServices();
            services.AddDomainServices();
            return services;
        }
    }
}
