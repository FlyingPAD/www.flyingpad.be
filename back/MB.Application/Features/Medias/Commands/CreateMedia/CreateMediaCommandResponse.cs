using MB.Application.Models;

namespace MB.Application.Features.Medias.Commands.CreateMedia;

public class CreateMediaCommandResponse : BaseResponse
{
    public Guid MediaId { get; set; }
}