using MB.Application.Models;

namespace MB.Application.Features.Styles.Commands.CreateStyle;

public class CreateStyleCommandResponse : BaseResponse
{
    public Guid StyleId { get; set; }
}
