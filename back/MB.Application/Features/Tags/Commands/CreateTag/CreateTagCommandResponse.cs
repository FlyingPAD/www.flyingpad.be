using MB.Application.Responses;

namespace MB.Application.Features.Tags.Commands.CreateTag;

public class CreateTagCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateTagDto Tag { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateTagCommandResponse() : base()
    {

    }
}
