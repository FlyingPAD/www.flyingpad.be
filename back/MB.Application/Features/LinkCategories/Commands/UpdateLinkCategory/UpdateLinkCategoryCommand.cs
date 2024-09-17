using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;

public class UpdateLinkCategoryCommand : IRequest<BaseResponse>
{
    public Guid LinkCategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}