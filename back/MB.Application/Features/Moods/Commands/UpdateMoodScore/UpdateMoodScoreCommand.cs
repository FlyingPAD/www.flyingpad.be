using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMoodScore;

public class UpdateMoodScoreCommand : IRequest<BaseResponse>
{
    public Guid MoodId { get; set; }
    public int Value { get; set; }
}