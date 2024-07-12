using MB.Application.Responses;

namespace MB.Application.Features.Models.Commands.DeleteModel;

public class DeleteModelCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public DeleteModelDto DeletedModelId { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public DeleteModelCommandResponse() : base()
    {

    }
}
