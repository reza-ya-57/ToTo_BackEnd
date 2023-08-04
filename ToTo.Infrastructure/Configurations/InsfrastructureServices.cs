using Microsoft.Extensions.DependencyInjection;


namespace ToTo.Infrastructure.Configurations
{
    public static class InsfrastructureServices
    {
        public static IServiceCollection AddInsfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<ToToContext>();
            return services;
        }
    }
}
