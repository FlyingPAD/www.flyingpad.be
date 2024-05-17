using MB.Domain.Entities;

namespace MB.Application.Contracts;

public interface ITokenManager
{
    string GenerateToken(User user);
}
