using System.Text;
using MB.Application.Interfaces.Infrastructure;
using MB.Application.Interfaces.Services;

namespace MB.Infrastructure.Jobs;

public class DailyReportJob(IDailyReportService reportService, IEMailService emailService)
{
    private readonly IDailyReportService _reportService = reportService ?? throw new ArgumentNullException(nameof(reportService));
    private readonly IEMailService _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));

    public async Task ExecuteAsync()
    {
        var model = await _reportService.GenerateReportAsync();

        var sb = new StringBuilder()
            .AppendLine("<ul>")
            .AppendLine($"  <li>Total Moods                 : {model.TotalMoods}</li>")
            .AppendLine($"  <li>Total Images                : {model.TotalImages} ({model.ImagesPercentage:P2})</li>")
            .AppendLine($"  <li>Total Videos                : {model.TotalVideos} ({model.VideosPercentage:P2})</li>")
            .AppendLine($"  <li>Total Tags                  : {model.TotalTags}</li>")
            .AppendLine($"  <li>Total Tag Categories        : {model.TotalTagCategories}</li>")
            .AppendLine($"  <li>Total Artists               : {model.TotalArtists}</li>")
            .AppendLine($"  <li>Total Styles                : {model.TotalStyles}</li>")
            .AppendLine($"  <li>Total Media                 : {model.TotalMedia}</li>")
            .AppendLine($"  <li>Total Franchises            : {model.TotalFranchises}</li>")
            .AppendLine($"  <li>Total Models                : {model.TotalModels}</li>")
            .AppendLine($"  <li>Total Males                 : {model.TotalMales} ({model.MalesPercentage:P2})</li>")
            .AppendLine($"  <li>Total Females               : {model.TotalFemales} ({model.FemalesPercentage:P2})</li>")
            .AppendLine($"  <li>Total Links                 : {model.TotalLinks}</li>")
            .AppendLine($"  <li>Total Link Categories       : {model.TotalLinkCategories}</li>")
            .AppendLine($"  <li>Total Users                 : {model.TotalUsers}</li>")
            .AppendLine($"  <li>Relations Artist-Style      : {model.TotalRelationsArtistStyle}</li>")
            .AppendLine($"  <li>Relations Franchise-Media   : {model.TotalRelationsFranchiseMedium}</li>")
            .AppendLine($"  <li>Relations Franchise-Model   : {model.TotalRelationsFranchiseModel}</li>")
            .AppendLine($"  <li>Relations Link-Artist       : {model.TotalRelationsLinkArtist}</li>")
            .AppendLine($"  <li>Relations Link-Category     : {model.TotalRelationsLinkCategory}</li>")
            .AppendLine($"  <li>Relations Link-Model        : {model.TotalRelationsLinkModel}</li>")
            .AppendLine($"  <li>Relations Mood-Artist       : {model.TotalRelationsMoodArtist}</li>")
            .AppendLine($"  <li>Relations Mood-Franchise    : {model.TotalRelationsMoodFranchise}</li>")
            .AppendLine($"  <li>Relations Mood-Model        : {model.TotalRelationsMoodModel}</li>")
            .AppendLine($"  <li>Relations Mood-Tag          : {model.TotalRelationsMoodTag}</li>")
            .AppendLine($"  <li>Expired Tokens Purged       : {model.ExpiredTokenCount}</li>")
            .AppendLine("</ul>");

        await _emailService.SendEmailAsync(
            toEmail: "tonyvan@live.fr",
            subject: "Flying PAD | Daily Report",
            body: sb.ToString()
        );
    }
}