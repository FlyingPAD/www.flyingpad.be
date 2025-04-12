using Hangfire;
using MB.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Configurations;

public static class HangFireJobsConfiguration
{
    public static void ConfigureRecurringJobs(IServiceProvider serviceProvider)
    {
        var recurringJobManager = serviceProvider.GetRequiredService<IRecurringJobManager>();

        recurringJobManager.AddOrUpdate<EmailJob>(
            "send-email-daily-at-21-00",
            x => x.ExecuteAsync(),
            "0 21 * * *");
    }
}