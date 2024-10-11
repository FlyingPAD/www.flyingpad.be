using MB.Domain.Entities;

namespace MB.Application.Interfaces;

public interface ITokenManager
{
    string GenerateToken(User user);
}