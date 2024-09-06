using Hangfire;
using MB.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Configurations;

public static class HangFireJobsConfiguration
{
    public static void ConfigureRecurringJobs(IServiceProvider serviceProvider)
    {
        var recurringJobManager = serviceProvider.GetRequiredService<IRecurringJobManager>();

        recurringJobManager.AddOrUpdate<IEMailService>(
            "send-email-daily-at-21-00",
            x => x.SendEmailAsync("tonyvan@live.fr", "Coucou !", "Ceci est un message envoyé tous les jours à 21:00."),
            "0 21 * * *");
    }
}
