using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;

public class UpdateLinkCategoryCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public UpdateLinkCategoryDto UpdatedLinkCategory { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public UpdateLinkCategoryCommandResponse() : base()
    {

    }
}
