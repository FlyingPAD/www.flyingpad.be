using MB.Application.Models;

namespace MB.Application.Features.Styles.Commands.CreateStyle;

public class CreateStyleCommandResponse : BaseResponse
{
    public Guid BusinessId { get; set; }
}
