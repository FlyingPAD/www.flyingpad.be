using Hangfire;

namespace MB.API.Configurations;

public static class HangfireServiceExtensions
{
    public static IServiceCollection AddCustomHangfire(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHangfire(config =>
        {
            config.UseSqlServerStorage(configuration.GetConnectionString("DBHangFire"));
        });

        services.AddHangfireServer();

        return services;
    }
}