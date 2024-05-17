namespace MB.Application.Features.Medias.Commands.CreateMedia;

public class CreateMediaDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
