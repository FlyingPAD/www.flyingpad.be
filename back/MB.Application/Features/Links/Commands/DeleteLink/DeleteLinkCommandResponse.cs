using MB.Application.Responses;

namespace MB.Application.Features.Links.Commands.DeleteLink;

public class DeleteLinkCommandResponse : BaseResponse
{
    public DeleteLinkDto DeletedLinkId { get; set; } = new DeleteLinkDto();
}
