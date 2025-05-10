using MB.Domain.UserAggregate;

namespace MB.Application.Interfaces.Services;

public interface ITokenManager
{
    string GenerateToken(User user);
}