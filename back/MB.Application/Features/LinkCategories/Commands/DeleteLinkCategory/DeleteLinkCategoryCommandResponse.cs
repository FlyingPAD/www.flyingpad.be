using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;

public class DeleteLinkCategoryCommandResponse : BaseResponse
{
    public DeleteLinkCategoryDto DeletedLinkCategoryId { get; set; } = new DeleteLinkCategoryDto();
}