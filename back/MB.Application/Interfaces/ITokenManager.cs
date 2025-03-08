using MB.Domain.UserAggregate;

namespace MB.Application.Interfaces;

public interface ITokenManager
{
    string GenerateToken(User user);
}