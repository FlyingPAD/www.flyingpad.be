using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Styles.Commands.UpdateStyle
{
    public class UpdateStyleCommand : IRequest<BaseResponse>
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
