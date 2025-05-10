using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Services;
using MB.Domain.UserAggregate;

namespace MB.Application.Services;

public class EmailTokenCleanupService(IBaseRepository<EmailVerificationToken> repo) : IEmailTokenCleanupService
{
    private readonly IBaseRepository<EmailVerificationToken> _repo = repo;

    public async Task<int> DeleteExpiredTokensAsync()
    {
        var allTokens = await _repo.GetAllAsync();

        var expired = allTokens
            .Where(t => t.ExpiresAt <= DateTimeOffset.UtcNow)
            .ToList();

        foreach (var token in expired)
            await _repo.DeleteAsync(token);

        return expired.Count;
    }
}