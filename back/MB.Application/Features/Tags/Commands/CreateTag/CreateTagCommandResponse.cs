using MB.Application.Models;

namespace MB.Application.Features.Tags.Commands.CreateTag;

public class CreateTagCommandResponse : BaseResponse
{
    public Guid BusinessId { get; set; }
}