namespace MB.Application.Interfaces.Infrastructure;

public interface IEMailService
{
    Task SendEmailAsync(string toEmail, string subject, string body);
}