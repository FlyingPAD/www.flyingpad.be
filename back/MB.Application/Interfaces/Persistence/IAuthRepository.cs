using MB.Domain.UserAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface IAuthRepository
{
    /// <summary>
    /// Vérifie les identifiants et retourne l’utilisateur si OK, sinon null.
    /// </summary>
    Task<User?> LoginAsync(string email, string password);

    /// <summary>
    /// Enregistre un nouvel utilisateur (haché + salt déjà faits en amont).
    /// </summary>
    Task<User> RegisterAsync(User user);

    /// <summary>
    /// Indique si un utilisateur avec cet email existe déjà.
    /// </summary>
    Task<bool> UserExists(string email);
}