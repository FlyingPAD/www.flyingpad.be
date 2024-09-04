using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommandHandler(IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<DeleteTagCategoryCommand, DeleteTagCategoryCommandResponse>
{
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<DeleteTagCategoryCommandResponse> Handle(DeleteTagCategoryCommand request, CancellationToken cancellationToken)
    {
        var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.Id) ?? throw new NotFoundException($"Tag Category with ID {request.Id} was not found.");

        await _tagCategoryRepository.DeleteAsync(tagCategory);

        return new DeleteTagCategoryCommandResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}