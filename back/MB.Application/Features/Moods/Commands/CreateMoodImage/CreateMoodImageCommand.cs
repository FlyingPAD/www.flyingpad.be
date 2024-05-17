using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMoodImage;

public class CreateMoodImageCommand : IRequest<CreateMoodImageCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Size { get; set; } = 0;
    public string Extension { get; set; } = string.Empty;
    public int Height { get; set; } = 0;
    public int Width { get; set; } = 0;
    public string SourceFile { get; set; } = string.Empty;
}