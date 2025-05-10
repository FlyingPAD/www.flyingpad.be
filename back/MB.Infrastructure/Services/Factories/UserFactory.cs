using System.Security.Cryptography;
using System.Text;
using MB.Domain.UserAggregate;
using MB.Domain.UserAggregate.Interfaces;

namespace MB.Infrastructure.Services.Factories;

public class UserFactory : IUserFactory
{
    public User Create(
        string userName,
        string firstName,
        string lastName,
        string email,
        string plainPassword,
        DateTime birthdate)
    {
        // 1) Création du salt + hash
        using var hmac = new HMACSHA512();
        var salt = hmac.Key;
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));

        // 2) Appel à la factory statique du domaine
        return User.Register(
            userName: userName,
            firstName: firstName,
            lastName: lastName,
            email: email,
            passwordHash: hash,
            passwordSalt: salt,
            birthdate: birthdate
        );
    }
}