namespace MB.Application.Interfaces.Infrastructure;

public interface ICaptchaValidator
{
    Task<bool> VerifyV2Async(string token);
    Task<bool> VerifyV3Async(string token, string action);
}