using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Tags.Commands.DeleteTag;

public class DeleteTagCommand : IRequest<BaseResponse>
{
    public Guid TagId { get; set; }
}