namespace MB.Application.Interfaces;

public interface IEMailService
{
    Task SendEmailAsync(string toEmail, string subject, string body);
}
