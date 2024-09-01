using MB.Application.Models;

namespace MB.Application.Features.Styles.Commands.CreateStyle;

public class CreateStyleCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateStyleDto Style { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateStyleCommandResponse() : base()
    {

    }
}
