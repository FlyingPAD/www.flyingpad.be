namespace MB.Application.Features.Statistics.Queries.GetStatistics;

public class GetStatisticsQueryDto
{
    public int TotalMoods { get; set; }
    public int TotalImages { get; set; }
    public double ImagesPercentage { get; set; }
    public int TotalVideos { get; set; }
    public double VideosPercentage { get; set; }
    public int TotalTags { get; set; }
    public int TotalTagCategories { get; set; }
    public int TotalArtists { get; set; }
    public int TotalStyles { get; set; }
    public int TotalMedia { get; set; }
    public int TotalFranchises { get; set; }
    public int TotalModels { get; set; }
    public int TotalMales { get; set; }
    public double MalesPercentage { get; set; }
    public int TotalFemales { get; set; }
    public double FemalesPercentage { get; set; }
    public int TotalLinks { get; set; }
    public int TotalLinkCategories { get; set; }
    public int TotalUsers { get; set; }
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