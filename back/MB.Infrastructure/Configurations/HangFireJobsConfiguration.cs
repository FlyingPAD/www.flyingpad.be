using Hangfire;
using MB.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Configurations;

public static class HangFireJobsConfiguration
{
    public static void ConfigureRecurringJobs(IServiceProvider serviceProvider)
    {
        var recurringJobManager = serviceProvider.GetRequiredService<IRecurringJobManager>();

        recurringJobManager.AddOrUpdate<IEMailService>(
            "send-email-every-2-minutes",
            x => x.SendEmailAsync("tonyvan@live.fr", "Coucou!", "Ceci est un message envoyé toutes les deux minutes."),
            "*/2 * * * *");  // Cron expression pour toutes les 2 minutes
    }
}