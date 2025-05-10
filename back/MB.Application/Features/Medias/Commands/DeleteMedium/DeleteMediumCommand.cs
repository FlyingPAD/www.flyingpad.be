using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Medias.Commands.DeleteMedium;

public class DeleteMediumCommand : IRequest<BaseResponse>
{
    public Guid MediumId { get; set; }
}