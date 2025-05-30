using System.Security.Cryptography;
using System.Text;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.UserAggregate;

namespace MB.Persistence.Repositories.Definitions;

public class AuthRepository(IUserRepository userRepo) : IAuthRepository
{
    private readonly IUserRepository _userRepo = userRepo;

    public async Task<User?> LoginAsync(string email, string password)
    {
        // 1) Charger l’utilisateur par email
        var user = await _userRepo.GetByEmailAsync(email);

        // 2) Vérifier qu’on dispose bien du hash et du salt
        if (user?.PasswordHash is null || user.PasswordSalt is null)
            return null;

        // 3) Vérifier le mot de passe
        return VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)
            ? user
            : null;
    }

    public async Task<User> RegisterAsync(User user)
    {
        // 1) Vérifier l’existence
        if (await _userRepo.GetByEmailAsync(user.Email) is not null)
            throw new InvalidOperationException("User already exists.");

        // 2) Persister via BaseRepository.CreateAsync
        return await _userRepo.CreateAsync(user);
    }

    public async Task<bool> UserExists(string email)
    {
        return await _userRepo.GetByEmailAsync(email) is not null;
    }

    // --- Méthode privée de vérification, inchangée ---
    private static bool VerifyPasswordHash(
        string password,
        byte[] storedHash,
        byte[] storedSalt)
    {
        using var hmac = new HMACSHA512(storedSalt);
        var computed = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computed.SequenceEqual(storedHash);
    }
}