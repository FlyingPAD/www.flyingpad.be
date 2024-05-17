using MediatR;

namespace MB.Application.Features.TagCategories.Commands.CreateTagCategory;

public class CreateTagCategoryCommand : IRequest<CreateTagCategoryCommandResponse>
{
    public string Name { get; set; } = string.Empty;
}
