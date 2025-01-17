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
}