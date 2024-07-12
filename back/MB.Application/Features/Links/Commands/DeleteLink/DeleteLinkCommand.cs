using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Links.Commands.DeleteLink;

public class DeleteLinkCommand : IRequest<BaseResponse>
{
    public Guid LinkId { get; set; }
}