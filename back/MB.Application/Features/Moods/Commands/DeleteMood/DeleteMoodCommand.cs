using MediatR;

namespace MB.Application.Features.Moods.Commands.DeleteMood
{
    public class DeleteMoodCommand : IRequest<DeleteMoodCommandResponse>
    {
        public Guid MoodId { get; set; }
    }
}