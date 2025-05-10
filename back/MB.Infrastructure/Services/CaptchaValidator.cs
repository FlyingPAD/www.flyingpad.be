namespace MB.Infrastructure.Services;

using System.Net.Http;
using System.Threading.Tasks;
using MB.Application.Interfaces.Infrastructure;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class CaptchaValidator(HttpClient http, IConfiguration config) : ICaptchaValidator
{
    private readonly HttpClient _http = http;
    private readonly IConfiguration _config = config;

    public async Task<bool> VerifyV2Async(string token)
    {
        var secret = _config.GetValue<string>("Captcha:V2Secret");
        if (string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(token))
            return false;

        var response = await _http.PostAsync(
            $"https://www.google.com/recaptcha/api/siteverify?secret={secret}&response={token}",
            null);
        var content = await response.Content.ReadAsStringAsync();
        if (string.IsNullOrWhiteSpace(content))
            return false;

        var json = JObject.Parse(content);
        bool success = json.Value<bool?>("success") ?? false;

        return success;
    }

    public async Task<bool> VerifyV3Async(string token, string action)
    {
        var secret = _config.GetValue<string>("Captcha:V3Secret", string.Empty);
        if (string.IsNullOrEmpty(secret) || string.IsNullOrEmpty(token))
            return false;

        var response = await _http.PostAsync(
            $"https://www.google.com/recaptcha/api/siteverify?secret={secret}&response={token}",
            null);

        var content = await response.Content.ReadAsStringAsync();
        if (string.IsNullOrWhiteSpace(content))
            return false;

        dynamic? json = JsonConvert.DeserializeObject(content);
        if (json == null)
            return false;

        bool success = (json.success as bool?) == true;
        string? returnedAction = json.action as string;
        double score = (double?)(json.score) ?? 0.0;

        return success
               && returnedAction == action
               && score >= 0.5;
    }
}