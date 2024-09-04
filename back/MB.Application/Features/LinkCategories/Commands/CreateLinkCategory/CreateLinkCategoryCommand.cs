using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;

public class CreateLinkCategoryCommand : IRequest<CreateLinkCategoryCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
