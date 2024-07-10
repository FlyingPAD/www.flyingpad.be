namespace MB.Application.Features.Models.Commands.CreateModel;

public class CreateModelCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateModelDto Model { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateModelCommandResponse() : base()
    {

    }
}
