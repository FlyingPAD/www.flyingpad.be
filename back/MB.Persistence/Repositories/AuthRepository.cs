using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace MB.Persistence.Repositories;

public class AuthRepository(Context context) : IAuthRepository
{
    private readonly Context _context = context;

    /// <summary>
    /// Logs in a user with the specified email and password.
    /// </summary>
    public async Task<User?> LoginAsync(string email, string password)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

        if (user != null && user.PasswordHash != null && user.PasswordSalt != null &&
            VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
        {
            return user;
        }
        return null;
    }

    /// <summary>
    /// Registers a new user with the specified password.
    /// </summary>
    public async Task<User> RegisterAsync(User user, string password)
    {
        if (await UserExists(user.Email))
        {
            throw new InvalidOperationException("User already exists.");
        }

        CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
        user.PasswordHash = passwordHash;
        user.PasswordSalt = passwordSalt;

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }

    /// <summary>
    /// Checks if a user with the specified email exists.
    /// </summary>
    public async Task<bool> UserExists(string email)
    {
        return await _context.Users.AnyAsync(u => u.Email == email);
    }

    /// <summary>
    /// Creates a password hash and salt for the specified password.
    /// </summary>
    private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512();
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    /// <summary>
    /// Verifies the password hash against the stored hash and salt.
    /// </summary>
    private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
    {
        using var hmac = new HMACSHA512(storedSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(storedHash);
    }
}
