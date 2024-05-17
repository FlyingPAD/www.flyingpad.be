namespace MB.Application.Features.Franchises.Commands.CreateFranchise;

public class CreateFranchiseDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
