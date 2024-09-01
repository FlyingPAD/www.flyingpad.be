using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsLinkCategory;

public class CreateRelationsLinkCategoryCommand : IRequest<BaseResponse>
{
    public Guid LinkId { get; set; }
    public List<Guid> CategoryIds { get; set; } = [];
}