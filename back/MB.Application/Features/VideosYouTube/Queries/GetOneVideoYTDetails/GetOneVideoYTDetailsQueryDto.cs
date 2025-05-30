namespace MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetails;

public class GetOneVideoYTDetailsQueryDto
{
    public Guid BusinessId { get; set; }
    public DateTime Created { get; set; } = DateTime.MinValue;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime Modified { get; set; } = DateTime.UtcNow;
    public string ModifiedBy { get; set; } = string.Empty;
    public int Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Score { get; set; }
    public int Posiion { get; set; }
    public string Extension { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}