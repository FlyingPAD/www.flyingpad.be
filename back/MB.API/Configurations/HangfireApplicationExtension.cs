using Hangfire;
using MB.Infrastructure.Configurations;

namespace MB.API.Configurations;

public static class HangfireApplicationExtensions
{
    public static IApplicationBuilder UseCustomRecurringJobs(this IApplicationBuilder app)
    {
        app.ApplicationServices
           .GetRequiredService<IRecurringJobManager>();
        HangFireJobsConfiguration.ConfigureRecurringJobs(app.ApplicationServices);

        return app;
    }
}