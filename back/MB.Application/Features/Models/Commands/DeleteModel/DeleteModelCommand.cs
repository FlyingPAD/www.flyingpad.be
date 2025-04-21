using MediatR;

namespace MB.Application.Features.Models.Commands.DeleteModel;

public class DeleteModelCommand : IRequest<BaseResponse>
{
    public Guid ModelId { get; set; }
}