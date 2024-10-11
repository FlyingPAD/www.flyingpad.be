using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;

public class CreateLinkCategoryCommandResponse : BaseResponse
{
    public Guid LinkCategoryId { get; set; }
}