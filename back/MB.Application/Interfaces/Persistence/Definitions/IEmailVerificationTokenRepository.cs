using MB.Domain.UserAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface IEmailVerificationTokenRepository : IBaseRepository<EmailVerificationToken>
{
    Task<EmailVerificationToken?> GetByTokenAsync(string token);
}