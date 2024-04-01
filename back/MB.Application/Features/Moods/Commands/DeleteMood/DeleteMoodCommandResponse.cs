using MB.Application.Responses;

namespace MB.Application.Features.Moods.Commands.DeleteMood
{
    public class DeleteMoodCommandResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public DeleteMoodDto DeletedMoodId { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public DeleteMoodCommandResponse() : base()
        {

        }
    }
}