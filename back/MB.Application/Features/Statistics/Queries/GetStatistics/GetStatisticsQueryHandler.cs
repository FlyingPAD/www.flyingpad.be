using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Statistics.Queries.GetStatistics;

public class GetStatisticsQueryHandler(
    IBaseRepository<Mood> moodRepository,
    IBaseRepository<Tag> tagRepository,
    IBaseRepository<TagCategory> tagCategoryRepository,
    IBaseRepository<Artist> artistRepository,
    IBaseRepository<Style> styleRepository,
    IBaseRepository<Media> mediaRepository,
    IBaseRepository<Franchise> franchiseRepository,
    IBaseRepository<Model> modelRepository,
    IBaseRepository<Link> linkRepository,
    IBaseRepository<LinkCategory> linkCategoriesRepository,
    IBaseRepository<User> userRepository,
    IBaseRepository<RelationArtistStyle> rArtistStyle,
    IBaseRepository<RelationFranchiseMedia> rFranchiseMedium,
    IBaseRepository<RelationFranchiseModel> rFranchiseModel,
    IBaseRepository<RelationLinkArtist> rLinkArtist,
    IBaseRepository<RelationLinkCategory> rLinkCategory,
    IBaseRepository<RelationLinkModel> rLinkModel,
    IBaseRepository<RelationMoodArtist> rMoodArtist,
    IBaseRepository<RelationMoodFranchise> rMoodFranchise,
    IBaseRepository<RelationMoodModel> rMoodModel,
    IBaseRepository<RelationMoodTag> rMoodTag
    ) : IRequestHandler<GetStatisticsQuery, GetStatisticsQueryResponse>
{
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
    private readonly IBaseRepository<Style> _styleRepository = styleRepository;
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;
    private readonly IBaseRepository<LinkCategory> _linkCategoriesRepository = linkCategoriesRepository;
    private readonly IBaseRepository<User> _userRepository = userRepository;
    private readonly IBaseRepository<RelationArtistStyle> _rArtistStyle = rArtistStyle;
    private readonly IBaseRepository<RelationFranchiseMedia> _rFranchiseMedium = rFranchiseMedium;
    private readonly IBaseRepository<RelationFranchiseModel> _rFranchiseModel = rFranchiseModel;
    private readonly IBaseRepository<RelationLinkArtist> _rLinkArtist = rLinkArtist;
    private readonly IBaseRepository<RelationLinkCategory> _rLinkCategory = rLinkCategory;
    private readonly IBaseRepository<RelationLinkModel> _rLinkModel = rLinkModel;
    private readonly IBaseRepository<RelationMoodArtist> _rMoodArtist = rMoodArtist;
    private readonly IBaseRepository<RelationMoodFranchise> _rMoodFranchise = rMoodFranchise;
    private readonly IBaseRepository<RelationMoodModel> _rMoodModel = rMoodModel;
    private readonly IBaseRepository<RelationMoodTag> _rMoodTag = rMoodTag;
    public async Task<GetStatisticsQueryResponse> Handle(GetStatisticsQuery request, CancellationToken cancellationToken)
    {
        var totalMoods = await _moodRepository.CountAsync();
        var totalImages = await _moodRepository.CountAsync(mood => mood.Type == 1);
        var totalVideos = await _moodRepository.CountAsync(mood => mood.Type == 2);
        var totalTags = await _tagRepository.CountAsync();
        var totalTagCategories = await _tagCategoryRepository.CountAsync();
        var totalArtists = await _artistRepository.CountAsync();
        var totalStyles = await _styleRepository.CountAsync();
        var totalMedia = await _mediaRepository.CountAsync();
        var totalFranchises = await _franchiseRepository.CountAsync();
        var totalModels = await _modelRepository.CountAsync();
        var totalMales = await _modelRepository.CountAsync(model => model.Gender == "M");
        var totalFemales = await _modelRepository.CountAsync(model => model.Gender == "F");
        var totalLinks = await _linkRepository.CountAsync();
        var totalLinkCategories = await _linkCategoriesRepository.CountAsync();
        var totalUsers = await _userRepository.CountAsync();
        var rArtistStyle = await _rArtistStyle.CountAsync();
        var rFranchiseMedium = await _rFranchiseMedium.CountAsync();
        var rFranchiseModel = await _rFranchiseModel.CountAsync();
        var rLinkArtist = await _rLinkArtist.CountAsync();
        var rLinkCategory = await _rLinkCategory.CountAsync();
        var rLinkModel = await _rLinkModel.CountAsync();
        var rMoodArtist = await _rMoodArtist.CountAsync();
        var rMoodFranchise = await _rMoodFranchise.CountAsync();
        var rMoodModel = await _rMoodModel.CountAsync();
        var rMoodTag = await _rMoodTag.CountAsync();

        return new GetStatisticsQueryResponse
        {
            Success = true,
            Message = "Statistics",
            Statistics = {
                TotalMoods = totalMoods,
                TotalImages = totalImages,
                ImagesPercentage = totalMoods > 0 ? (totalImages / (double)totalMoods) * 100 : 0,
                TotalVideos = totalVideos,
                VideosPercentage = totalMoods > 0 ? (totalVideos / (double)totalMoods) * 100 : 0,
                TotalTags = totalTags,
                TotalTagCategories = totalTagCategories,
                TotalArtists = totalArtists,
                TotalStyles = totalStyles,
                TotalMedia = totalMedia,
                TotalFranchises = totalFranchises,
                TotalModels = totalModels,
                TotalMales = totalMales,
                MalesPercentage = totalModels > 0 ? (totalMales / (double)totalModels) * 100 : 0,
                TotalFemales = totalFemales,
                FemalesPercentage = totalModels > 0 ? (totalFemales / (double)totalModels) * 100 : 0,
                TotalLinks = totalLinks,
                TotalLinkCategories = totalLinkCategories,
                TotalUsers = totalUsers,
                TotalRelationsArtistStyle = rArtistStyle,
                TotalRelationsFranchiseMedium = rFranchiseMedium,
                TotalRelationsFranchiseModel = rFranchiseModel,
                TotalRelationsLinkArtist = rLinkArtist,
                TotalRelationsLinkCategory = rLinkCategory,
                TotalRelationsLinkModel = rLinkModel,
                TotalRelationsMoodArtist = rMoodArtist,
                TotalRelationsMoodFranchise = rMoodFranchise,
                TotalRelationsMoodModel = rMoodModel,
                TotalRelationsMoodTag = rMoodTag
            }
        };
    }
}