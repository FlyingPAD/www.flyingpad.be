using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.UserAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class EmailVerificationTokenRepository(Context context) : BaseRepository<EmailVerificationToken>(context), IEmailVerificationTokenRepository
{
    public async Task<EmailVerificationToken?> GetByTokenAsync(string token)
    {
        return await _context.EmailVerificationTokens
                             .Include(x => x.User)
                             .FirstOrDefaultAsync(x => x.Token == token);
    }
}