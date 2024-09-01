using MB.Application.Models;

namespace MB.Application.Features.Moods.Commands.UpdateMood;

public class UpdateMoodCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public UpdateMoodDto UpdatedMood { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public UpdateMoodCommandResponse() : base()
    {

    }
}
