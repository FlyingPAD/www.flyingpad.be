namespace MB.Application.Features.Statistics.Queries.GetStatistics;

public class GetStatisticsQueryDto
{
    // Moods
    public int TotalNewMoods { get; set; }
    public int TotalMoods { get; set; }
    public int TotalImages { get; set; }
    public double ImagesPercentage { get; set; }
    public int TotalVideos { get; set; }
    public double VideosPercentage { get; set; }
    public int TotalYouTubeVideos { get; set; }
    public double YouTubeVideosPercentage { get; set; }
    public int TotalSoundCloudAudios { get; set; }
    public double SoundCloudAudiosPercentage { get; set; }
    // Tags
    public int TotalTags { get; set; }
    public int TotalTagCategories { get; set; }
    // Artists
    public int TotalArtists { get; set; }
    public int TotalStyles { get; set; }
    // Franchises
    public int TotalMedia { get; set; }
    public int TotalFranchises { get; set; }
    // Models
    public int TotalModels { get; set; }
    public int TotalMales { get; set; }
    public double MalesPercentage { get; set; }
    public int TotalFemales { get; set; }
    public double FemalesPercentage { get; set; }
    // Links
    public int TotalLinks { get; set; }
    public int TotalLinkCategories { get; set; }
    // Users 
    public int TotalUsers { get; set; }
    // Relations
    public int TotalRelationsArtistStyle { get; set; }
    public int TotalRelationsFranchiseMedium { get; set; }
    public int TotalRelationsFranchiseModel { get; set; }
    public int TotalRelationsLinkArtist { get; set; }
    public int TotalRelationsLinkCategory { get; set; }
    public int TotalRelationsLinkModel { get; set; }
    public int TotalRelationsMoodArtist { get; set; }
    public int TotalRelationsMoodFranchise { get; set; }
    public int TotalRelationsMoodModel { get; set; }
    public int TotalRelationsMoodTag { get; set; }
}