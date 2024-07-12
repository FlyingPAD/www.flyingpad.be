using MB.Application.Responses;

namespace MB.Application.Features.Tags.Commands.UpdateTag;

public class UpdateTagCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public UpdateTagDto UpdatedTag { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public UpdateTagCommandResponse() : base()
    {

    }
}
