using MB.Application.Contracts;
using MB.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MB.Application.Security;

/// <summary>
/// Constructor :
/// </summary>
/// <param name="config"></param>
public class TokenManager(IConfiguration config) : ITokenManager
{
    private readonly string? _issuer = config.GetSection("Jwt").GetSection("Issuer").Value, 
                             _audience = config.GetSection("Jwt").GetSection("Audience").Value, 
                             _key = config.GetSection("Jwt").GetSection("Key").Value;

    /// <summary>
    /// Generate Token
    /// </summary>
    public string GenerateToken(User user)
    {
        ArgumentNullException.ThrowIfNull(user);
        if (string.IsNullOrEmpty(_key)) throw new InvalidOperationException("JWT may not be null or empty");

        // Create sign in key 

        SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_key));
        SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha512);

        // Payload Creation / User Info

        Claim[] claims = 
        [
            new ("businessId", user.BusinessId.ToString()),
            new ("created", user.Created.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")),
            new ("modified", user.Modified.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")),
            new ("firstName", user.FirstName.ToString()),
            new ("lastName", user.LastName.ToString()),
            new ("email", user.Email.ToString()),
            new ("birthdate", user.Birthdate.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")),
            new ("role", user.Role.ToString())
        ];

        // Token Configuration

        JwtSecurityToken token = new (
                claims: claims,
                signingCredentials: credentials,
                issuer: _issuer,
                audience: _audience,
                expires: DateTime.Now.AddDays(1)
            );

        // Token Generation

        JwtSecurityTokenHandler handler = new ();

        return handler.WriteToken(token);
    }
}