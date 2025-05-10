namespace MB.Application.Interfaces.Services;

public interface IEmailTokenCleanupService
{
    Task<int> DeleteExpiredTokensAsync();
}