namespace MB.Application.Contracts
{
    public interface IEMailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
    }
}
