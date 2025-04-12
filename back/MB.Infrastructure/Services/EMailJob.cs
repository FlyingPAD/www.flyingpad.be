using MB.Application.Interfaces.Infrastructure;

namespace MB.Infrastructure.Services;

public class EmailJob(IEMailService emailService, IEmailDataService emailDataService)
{
    private readonly IEMailService _emailService = emailService;
    private readonly IEmailDataService _emailDataService = emailDataService;

    public async Task ExecuteAsync()
    {
        var totalArtists = await _emailDataService.CountArtistsAsync();

        var message = $"Total Artists : {totalArtists}";

        await _emailService.SendEmailAsync("tonyvan@live.fr", "www.flyingpad.be | Daily Status", message);
    }
}