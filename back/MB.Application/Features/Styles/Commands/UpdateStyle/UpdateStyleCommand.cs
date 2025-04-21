using MediatR;

namespace MB.Application.Features.Styles.Commands.UpdateStyle;

public class UpdateStyleCommand : IRequest<BaseResponse>
{
    public Guid StyleId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}