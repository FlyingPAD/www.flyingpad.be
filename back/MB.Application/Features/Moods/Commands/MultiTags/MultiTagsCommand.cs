using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.MultiTags;

public class MultiTagsCommand : IRequest<BaseResponse>
{
    public IEnumerable<Guid> MoodIds { get; set; } = [];
    public IEnumerable<Guid> Tags { get; set; } = [];
}