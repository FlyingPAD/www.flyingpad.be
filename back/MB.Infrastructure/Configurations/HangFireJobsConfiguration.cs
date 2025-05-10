using Hangfire;
using MB.Infrastructure.Jobs;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Configurations;

public static class HangFireJobsConfiguration
{
    public static void ConfigureRecurringJobs(IServiceProvider serviceProvider)
    {
        var manager = serviceProvider.GetRequiredService<IRecurringJobManager>();

        // purge tous les jours à 03:00
        manager.AddOrUpdate<CleanupExpiredTokensJob>(
            "cleanup-expired-email-tokens",
            job => job.ExecuteAsync(),
            "0 3 * * *"
        );

        // rapport tous les jours à 21:00
        manager.AddOrUpdate<DailyReportJob>(
            "daily-report-job",
            job => job.ExecuteAsync(),
            "0 21 * * *"
        );

        // Process des Saisons tous les lundis à minuit
        manager.AddOrUpdate<ProcessSeasonsJob>(
            "process-weekly-seasons",
            job => job.ExecuteAsync(),
            "0 0 * * 1"   
        );
    }
}