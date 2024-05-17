using MB.Application.Responses;

namespace MB.Application.Features.TagCategories.Commands.CreateTagCategory;

public class CreateTagCategoryCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateTagCategoryDto TagCategory { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateTagCategoryCommandResponse() : base()
    {

    }
}
