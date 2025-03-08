using MB.Application.Interfaces.Infrastructure;
using MB.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IFileService, FileService>();
        services.AddScoped<IEMailService, EMailService>();

        services.AddHttpClient();

        return services;
    }
}