using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence;

public interface IAuthRepository
{
    Task<User?> LoginAsync(string email, string password);
    Task<User> RegisterAsync(User user, string password);
    Task<bool> UserExists(string email);
}