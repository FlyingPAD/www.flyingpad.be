using MB.Application.Interfaces.Infrastructure;
using MB.Infrastructure.Jobs;
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

        services
          .AddHttpClient<CaptchaValidator>()
          .Services
          .AddScoped<ICaptchaValidator>(sp => sp.GetRequiredService<CaptchaValidator>());

        services.AddTransient<ISoundCloudService, SoundCloudOembedService>();

        services.AddScoped<DailyReportJob>();
        services.AddScoped<CleanupExpiredTokensJob>();
        services.AddScoped<ProcessSeasonsJob>();

        services.AddScoped<MB.Domain.UserAggregate.Interfaces.IUserFactory, MB.Infrastructure.Services.Factories.UserFactory>();


        return services;
    }
}