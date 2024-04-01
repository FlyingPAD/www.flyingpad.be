using MB.Application.Responses;

namespace MB.Application.Features.Models.Commands.UpdateModel
{
    public class UpdateModelCommandResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public UpdateModelDto UpdatedModel { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public UpdateModelCommandResponse() : base()
        {

        }
    }
}
