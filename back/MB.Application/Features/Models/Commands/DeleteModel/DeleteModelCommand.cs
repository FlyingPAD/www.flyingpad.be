using MediatR;

namespace MB.Application.Features.Models.Commands.DeleteModel
{
    public class DeleteModelCommand : IRequest<DeleteModelCommandResponse>
    {
        public Guid ModelId { get; set; }
    }
}
