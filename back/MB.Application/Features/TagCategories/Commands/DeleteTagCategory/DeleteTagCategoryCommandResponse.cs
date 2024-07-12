using MB.Application.Responses;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public DeleteTagCategoryDto DeletedTagCategoryId { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public DeleteTagCategoryCommandResponse() : base()
    {

    }
}
