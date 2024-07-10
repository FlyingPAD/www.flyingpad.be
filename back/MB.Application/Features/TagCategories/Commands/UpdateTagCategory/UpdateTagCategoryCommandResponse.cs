namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory;

public class UpdateTagCategoryCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public UpdateTagCategoryDto UpdatedTagCategory { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public UpdateTagCategoryCommandResponse() : base()
    {

    }
}
