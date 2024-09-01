using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Models.Commands.UpdateModel;

public class UpdateModelCommand : IRequest<BaseResponse>
{
    public Guid ModelId { get; set; }
    public string Pseudonym { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}