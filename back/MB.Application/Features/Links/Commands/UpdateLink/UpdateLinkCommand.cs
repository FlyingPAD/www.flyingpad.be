using MediatR;

namespace MB.Application.Features.Links.Commands.UpdateLink;

public class UpdateLinkCommand : IRequest<BaseResponse>
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
