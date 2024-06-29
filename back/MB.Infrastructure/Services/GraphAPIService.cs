using MB.Application.Contracts;
using MB.Application.Dto;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MB.Infrastructure.Services
{
    public class GraphAPIService(IHttpClientFactory httpClientFactory, IConfiguration configuration, IAuthentificationService authService) : IGraphAPIService
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;
        private readonly IConfiguration _configuration = configuration;
        private readonly IAuthentificationService _authService = authService;

        public async Task<IEnumerable<AzureUserDto>> GetUsersAsync()
        {
            var accessToken = await _authService.GetAccessToken(CancellationToken.None);
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var uri = $"{_configuration["MicrosoftGraph:BaseUrl"]}/v1.0/users?$select=displayName,mail,jobTitle";
            var response = await client.GetFromJsonAsync<GraphUsersResponse>(uri);

            if (response?.Value != null)
            {
                return response.Value.Select(u => new AzureUserDto
                {
                    DisplayName = u.DisplayName,
                    Email = u.Email,
                    JobTitle = u.JobTitle
                }).ToList();
            }
            else
            {
                return [];
            }
        }
    }

    public class GraphUsersResponse
    {
        public List<AzureUserDto> Value { get; set; } = [];
    }
}