using MB.Application.Models;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommandResponse : BaseResponse
{
    public Guid LinkId { get; set; }
}