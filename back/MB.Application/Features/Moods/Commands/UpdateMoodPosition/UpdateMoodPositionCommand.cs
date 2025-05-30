using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMoodPosition;

public class UpdateMoodPositionCommand : IRequest<BaseResponse>
{
    public List<Guid> MoodIds { get; set; } = [];
    public int Position { get; set; }
}