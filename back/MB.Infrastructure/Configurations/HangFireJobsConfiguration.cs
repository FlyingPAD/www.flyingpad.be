using Hangfire;
using MB.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Configurations;

public static class HangFireJobsConfiguration
{
    public static void ConfigureRecurringJobs(IRecurringJobManager recurringJobManager, IServiceProvider serviceProvider)
    {
        recurringJobManager.AddOrUpdate(
            "send-email-every-2-minutes",
            () => serviceProvider.GetRequiredService<IEMailService>().SendEmailAsync("recipient@example.com", "Coucou!", "Ceci est un message envoyé toutes les deux minutes."),
            "*/2 * * * *");  // Cron expression pour toutes les 2 minutes
    }
}