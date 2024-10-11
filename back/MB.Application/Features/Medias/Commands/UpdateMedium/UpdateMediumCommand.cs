using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Medias.Commands.UpdateMedium;

public class UpdateMediumCommand : IRequest<BaseResponse>
{
    public Guid MediumId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}