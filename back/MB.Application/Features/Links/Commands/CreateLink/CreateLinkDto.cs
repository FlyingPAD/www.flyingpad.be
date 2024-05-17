namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
