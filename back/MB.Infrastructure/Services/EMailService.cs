using MB.Application.Interfaces.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace MB.Infrastructure.Services;

public class EMailService : IEMailService
{
    private readonly SmtpClient _smtpClient;
    private readonly MailAddress _fromAddress;

    public EMailService(IConfiguration configuration)
    {
        string smtpServer = configuration["EmailSettings:SmtpServer"] ?? "default-smtp-server";
        string smtpPortStr = configuration["EmailSettings:SmtpPort"] ?? "465";
        int smtpPort = int.TryParse(smtpPortStr, out var port) ? port : 465;
        string smtpUsername = configuration["EmailSettings:SmtpUsername"] ?? "default@yourdomain.com";
        string smtpPassword = configuration["EmailSettings:SmtpPassword"] ?? "defaultpassword";
        string displayName = "Flying PAD";

        _fromAddress = new MailAddress(smtpUsername, displayName);

        _smtpClient = new SmtpClient
        {
            Host = smtpServer,
            Port = smtpPort,
            EnableSsl = false,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(smtpUsername, smtpPassword)
        };
    }

    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var toAddress = new MailAddress(toEmail);

        using var message = new MailMessage(_fromAddress, toAddress)
        {
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        };
        await _smtpClient.SendMailAsync(message);
    }
}