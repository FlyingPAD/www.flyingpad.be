using MB.Application.Responses;

namespace MB.Application.Features.Medias.Commands.UpdateMedia;

public class UpdateMediaCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public UpdateMediaDto UpdatedMedia { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public UpdateMediaCommandResponse() : base()
    {

    }
}
