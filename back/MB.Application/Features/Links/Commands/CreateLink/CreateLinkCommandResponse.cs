using MB.Application.Responses;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommandResponse : BaseResponse
{
    public CreateLinkDto Link { get; set; } = default!;
}
