using MediatR;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommand : IRequest<CreateLinkCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public List<Guid> LinkCategoryIds { get; set; } = [];
}