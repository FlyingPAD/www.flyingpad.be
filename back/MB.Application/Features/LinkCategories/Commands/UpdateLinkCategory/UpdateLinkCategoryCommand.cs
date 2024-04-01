using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory
{
    public class UpdateLinkCategoryCommand : IRequest<UpdateLinkCategoryCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
