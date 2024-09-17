using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMood;

public class UpdateMoodCommand : IRequest<BaseResponse>
{
    public Guid MoodId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
