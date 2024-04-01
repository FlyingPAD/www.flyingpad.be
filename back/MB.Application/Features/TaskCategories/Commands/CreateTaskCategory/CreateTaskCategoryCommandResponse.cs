using MB.Application.Responses;

namespace MB.Application.Features.TaskCategories.Commands.CreateTaskCategory
{
    public class CreateTaskCategoryCommandResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public CreateTaskCategoryDto TaskCategory { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public CreateTaskCategoryCommandResponse() : base()
        {

        }
    }
}
