namespace MB.Application.Features.Franchises.Commands.UpdateFranchise;

public class UpdateFranchiseDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
