using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodModel;

public class CreateRelationsMoodModelCommand : IRequest<BaseResponse>
{
    public Guid MoodId { get; set; }
    public List<Guid> ModelIds { get; set; } = [];
}
