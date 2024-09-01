using MB.Application.Models;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommandResponse : BaseResponse
{
    public CreateLinkDto Link { get; set; } = default!;
}
