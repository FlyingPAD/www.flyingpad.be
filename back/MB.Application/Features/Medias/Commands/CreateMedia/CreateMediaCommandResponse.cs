using MB.Application.Responses;

namespace MB.Application.Features.Medias.Commands.CreateMedia;

public class CreateMediaCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateMediaDto Media { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateMediaCommandResponse() : base()
    {

    }
}
