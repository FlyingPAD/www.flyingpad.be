using MB.Application.Features.Statistics.Queries.GetStatistics;
using MB.Application.Interfaces.Services;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Services;

public class DailyReportService(
    IMediator mediator,
    IEmailTokenCleanupService cleanupService) : IDailyReportService
{
    private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    private readonly IEmailTokenCleanupService _cleanupService = cleanupService ?? throw new ArgumentNullException(nameof(cleanupService));

    public async Task<DailyReportModel> GenerateReportAsync()
    {
        var response = await _mediator.Send(new GetStatisticsQuery());

        if (!response.Success || response.Statistics == null)
        {
            throw new InvalidOperationException("Échec lors de la récupération des statistiques.");
        }

        var stats = response.Statistics;

        int expiredCount = await _cleanupService.DeleteExpiredTokensAsync();

        return new DailyReportModel
        {
            TotalMoods = stats.TotalMoods,
            TotalImages = stats.TotalImages,
            ImagesPercentage = stats.ImagesPercentage,
            TotalVideos = stats.TotalVideos,
            VideosPercentage = stats.VideosPercentage,
            TotalTags = stats.TotalTags,
            TotalTagCategories = stats.TotalTagCategories,
            TotalArtists = stats.TotalArtists,
            TotalStyles = stats.TotalStyles,
            TotalMedia = stats.TotalMedia,
            TotalFranchises = stats.TotalFranchises,
            TotalModels = stats.TotalModels,
            TotalMales = stats.TotalMales,
            MalesPercentage = stats.MalesPercentage,
            TotalFemales = stats.TotalFemales,
            FemalesPercentage = stats.FemalesPercentage,
            TotalLinks = stats.TotalLinks,
            TotalLinkCategories = stats.TotalLinkCategories,
            TotalUsers = stats.TotalUsers,
            TotalRelationsArtistStyle = stats.TotalRelationsArtistStyle,
            TotalRelationsFranchiseMedium = stats.TotalRelationsFranchiseMedium,
            TotalRelationsFranchiseModel = stats.TotalRelationsFranchiseModel,
            TotalRelationsLinkArtist = stats.TotalRelationsLinkArtist,
            TotalRelationsLinkCategory = stats.TotalRelationsLinkCategory,
            TotalRelationsLinkModel = stats.TotalRelationsLinkModel,
            TotalRelationsMoodArtist = stats.TotalRelationsMoodArtist,
            TotalRelationsMoodFranchise = stats.TotalRelationsMoodFranchise,
            TotalRelationsMoodModel = stats.TotalRelationsMoodModel,
            TotalRelationsMoodTag = stats.TotalRelationsMoodTag,

            ExpiredTokenCount = expiredCount
        };
    }
}