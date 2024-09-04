using MB.Application.Models;

namespace MB.Application.Features.Models.Commands.CreateModel;

public class CreateModelCommandResponse : BaseResponse
{
    public Guid ModelId { get; set; }
}
