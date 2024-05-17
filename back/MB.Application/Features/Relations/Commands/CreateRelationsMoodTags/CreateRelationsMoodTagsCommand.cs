using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags;

public class CreateRelationsMoodTagsCommand : IRequest<BaseResponse>
{
    public Guid MoodId { get; set; }
    public List<Guid> TagIds { get; set; } = [];
}
