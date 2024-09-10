using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory;

public class UpdateTagCategoryCommand : IRequest<BaseResponse>
{
    public Guid TagCategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}