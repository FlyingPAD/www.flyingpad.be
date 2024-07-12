using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Styles.Commands.DeleteStyle;

public class DeleteStyleCommand : IRequest<BaseResponse>
{
    public Guid StyleId { get; set; }
}