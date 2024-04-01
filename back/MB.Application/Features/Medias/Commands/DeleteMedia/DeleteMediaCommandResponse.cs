using MB.Application.Responses;

namespace MB.Application.Features.Medias.Commands.DeleteMedia
{
    public class DeleteMediaCommandResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public DeleteMediaDto DeletedMediaId { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public DeleteMediaCommandResponse() : base()
        {

        }
    }
}
