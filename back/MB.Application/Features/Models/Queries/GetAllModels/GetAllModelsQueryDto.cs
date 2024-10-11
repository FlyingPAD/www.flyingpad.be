namespace MB.Application.Features.Models.Queries.GetAllModels;

public class GetAllModelsQueryDto
{
    public Guid BusinessId { get; set; }
    public string Pseudonym { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
}