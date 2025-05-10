using MB.Application.Interfaces.Services;

namespace MB.Infrastructure.Jobs;

public class CleanupExpiredTokensJob(IEmailTokenCleanupService cleanupService)
{
    private readonly IEmailTokenCleanupService _cleanupService = cleanupService;

    public async Task ExecuteAsync()
    {
        int deleted = await _cleanupService.DeleteExpiredTokensAsync();
    }
}