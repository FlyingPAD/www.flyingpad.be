using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory
{
    public class DeleteLinkCategoryCommand : IRequest<DeleteLinkCategoryCommandResponse>
    {
        public Guid LinkCategoryId { get; set; }
    }
}
