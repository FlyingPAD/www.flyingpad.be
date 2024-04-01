using MB.Application.Responses;

namespace MB.Application.Features.Links.Commands.UpdateLink
{
    public class UpdateLinkCommandResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public UpdateLinkDto UpdatedLink { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public UpdateLinkCommandResponse() : base()
        {

        }
    }
}
