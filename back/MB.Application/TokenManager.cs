using MB.Application.Interfaces;
using MB.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MB.Application;

public class TokenManager(IConfiguration config) : ITokenManager
{
    private readonly string? _issuer = config.GetSection("Jwt").GetSection("Issuer").Value,
                             _audience = config.GetSection("Jwt").GetSection("Audience").Value,
                             _key = config.GetSection("Jwt").GetSection("Key").Value;

    public string GenerateToken(User user)
    {
        ArgumentNullException.ThrowIfNull(user);
        if (string.IsNullOrEmpty(_key)) throw new InvalidOperationException("JWT may not be null or empty");

        SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_key));
        SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha512);

        Claim[] claims =
        [
            new ("businessId", user.BusinessId.ToString()),
            new ("created", user.Created.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")),
            new ("modified", user.Modified.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")),
            new ("pseudonym", user.Pseudonym.ToString()),
            new ("firstName", user.FirstName.ToString()),
            new ("lastName", user.LastName.ToString()),
            new ("email", user.Email.ToString()),
            new ("birthdate", user.Birthdate.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")),
            new ("role", user.Role.ToString())
        ];

        JwtSecurityToken token = new(
                claims: claims,
                signingCredentials: credentials,
                issuer: _issuer,
                audience: _audience,
                expires: DateTime.Now.AddDays(1)
            );
        JwtSecurityTokenHandler handler = new();

        return handler.WriteToken(token);
    }
}