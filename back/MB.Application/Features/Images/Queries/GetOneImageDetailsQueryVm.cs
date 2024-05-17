namespace MB.Application.Features.Images.Queries;

public class GetOneImageDetailsQueryVm
{
    public Guid BusinessId { get; set; } = Guid.Empty;
    public DateTime Created { get; set; } = DateTime.MinValue;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime Modified { get; set; } = DateTime.UtcNow;
    public string ModifiedBy { get; set; } = string.Empty;
    public int Type { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public int Score { get; set; } = 0;
    public string Extension { get; set; } = string.Empty;
    public int Size { get; set; } = 0;
    public int Height { get; set; } = 0;
    public int Width { get; set; } = 0;
}