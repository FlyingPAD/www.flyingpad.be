namespace MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;

public class CreateLinkCategoryCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateLinkCategoryDto LinkCategory { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateLinkCategoryCommandResponse() : base()
    {

    }
}
