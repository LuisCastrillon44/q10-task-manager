using Q10.TaskManager.Infrastructure.Interfaces;
using Q10.TaskManager.Infrastructure.Repositories;

namespace Q10.TaskManager.Api.Configurations
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IConfig, SettingsRepository>();
            services.AddScoped<ICacheRepository, CacheRepository>();

            return services;
        }
    }
}
