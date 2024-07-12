using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Moods.Commands.DeleteMood;

public class DeleteMoodCommand : IRequest<BaseResponse>
{
    public Guid MoodId { get; set; }
}