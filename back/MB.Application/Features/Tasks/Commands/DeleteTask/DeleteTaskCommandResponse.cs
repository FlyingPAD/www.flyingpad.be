using MB.Application.Responses;

namespace MB.Application.Features.Tasks.Commands.DeleteTask
{
    public class DeleteTaskCommandResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public DeleteTaskDto Task { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public DeleteTaskCommandResponse() : base()
        {

        }
    }
}
