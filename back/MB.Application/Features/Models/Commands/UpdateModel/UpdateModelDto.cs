namespace MB.Application.Features.Models.Commands.UpdateModel;

public class UpdateModelDto
{
    public Guid BusinessId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
