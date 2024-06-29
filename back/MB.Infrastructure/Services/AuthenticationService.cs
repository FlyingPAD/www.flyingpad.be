using MB.Application.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;

namespace MB.Infrastructure.Services;

public class AuthenticationService(IConfiguration configuration) : IAuthentificationService
{
    private readonly IConfidentialClientApplication _confidentialClientApp = ConfidentialClientApplicationBuilder
            .Create(configuration["AzureB2C:ClientIdGraphAccessor"])
            .WithClientSecret(configuration["AzureB2C:ClientSecretGraphAccessor"])
            .WithAuthority($"https://login.microsoftonline.com/{configuration["AzureB2C:TenantId"]}")
            .Build();

    public async Task<string> GetAccessToken(CancellationToken cancellationToken)
    {
        var scopes = new string[] { "https://graph.microsoft.com/.default" };
        var authResult = await _confidentialClientApp.AcquireTokenForClient(scopes).ExecuteAsync(cancellationToken);
        return authResult.AccessToken;
    }
}