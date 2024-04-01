using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMood
{
    public class UpdateMoodCommand : IRequest<UpdateMoodCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
