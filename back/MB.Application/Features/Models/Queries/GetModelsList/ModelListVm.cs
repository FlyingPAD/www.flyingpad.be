namespace MB.Application.Features.Models.Queries.GetModelsList;

public class ModelListVm
{
    public Guid BusinessId { get; set; }
    public string Pseudonym { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
}
