using Serilog;

namespace MB.API.Configurations;

public static class LoggingExtensions
{
    public static void ConfigureCustomSerilog(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseSerilog((context, services, configuration) =>
        {
            var currentDateTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            configuration
                .ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services)
                .WriteTo.Async(a => a.File($"Logs/FlyingPAD_{currentDateTime}.txt",
                                 outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"));
        });
    }
}