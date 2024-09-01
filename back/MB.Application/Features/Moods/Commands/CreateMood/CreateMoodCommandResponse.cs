using MB.Application.Models;

namespace MB.Application.Features.Moods.Commands.CreateMood;

public class CreateMoodCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateMoodDto Mood { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateMoodCommandResponse() : base()
    {

    }
}
