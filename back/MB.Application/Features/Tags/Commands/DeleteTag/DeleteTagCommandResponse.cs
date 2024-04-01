using MB.Application.Responses;

namespace MB.Application.Features.Tags.Commands.DeleteTag
{
    public class DeleteTagCommandResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public DeleteTagDto DeletedTagId { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public DeleteTagCommandResponse() : base()
        {

        }
    }
}
