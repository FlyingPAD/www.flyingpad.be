using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;

public class DeleteLinkCategoryCommand : IRequest<BaseResponse>
{
    public Guid LinkCategoryId { get; set; }
}
