using MB.Application.Responses;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateLinkDto Link { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateLinkCommandResponse() : base()
    {

    }
}
