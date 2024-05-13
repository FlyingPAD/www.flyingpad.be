using Hangfire;
using MB.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Configurations
{
    public static class HangFireJobsConfiguration
    {
        public static void ConfigureRecurringJobs(IRecurringJobManager recurringJobManager, IServiceProvider serviceProvider)
        {
            recurringJobManager.AddOrUpdate(
                "send-daily-email",
                () => serviceProvider.GetRequiredService<IEMailService>().SendEmailAsync("recipient@example.com", "Coucou!", "C'est votre email quotidien."),
                "0 20 * * *");
        }
    }
}