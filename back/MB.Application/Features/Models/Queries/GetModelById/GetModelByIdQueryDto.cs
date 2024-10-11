namespace MB.Application.Features.Models.Queries.GetModelById;

public class GetModelByIdQueryDto
{
    public Guid BusinessId { get; set; }
    public DateTime Created { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime Modified { get; set; }
    public string ModifiedBy { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Pseudonym { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}