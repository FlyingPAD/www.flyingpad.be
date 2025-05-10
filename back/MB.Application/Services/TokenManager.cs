using MB.Application.Interfaces.Services;
using MB.Domain.UserAggregate;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MB.Application.Services;

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