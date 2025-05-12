using System.Security.Cryptography;
using System.Text;
using MB.Domain.UserAggregate;
using MB.Domain.UserAggregate.Interfaces;

namespace MB.Infrastructure.Services.Factories;

public class UserFactory : IUserFactory
{
    public User Create(
        string? userName,
        string? firstName,
        string? lastName,
        string email,
        string plainPassword,
        DateTime? birthdate)
    {
        using var hmac = new HMACSHA512();
        var salt = hmac.Key;
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));

        return User.Register(
            email: email,
            passwordHash: hash,
            passwordSalt: salt
        );
    }
}