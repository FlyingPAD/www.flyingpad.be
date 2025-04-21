using MediatR;

namespace MB.Application.Features.Moods.Commands.MultiTags;

public class MultiTagsCommand : IRequest<BaseResponse>
{
    public Guid[] MoodIds { get; set; } = [];
    public Guid[] TagsToAdd { get; set; } = [];
    public Guid[] TagsToRemove { get; set; } = [];
}