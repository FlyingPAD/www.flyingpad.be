using MB.Application.Models;

namespace MB.Application.Features.Medias.Commands.CreateMedium;

public class CreateMediumCommandResponse : BaseResponse
{
    public Guid MediumId { get; set; }
}