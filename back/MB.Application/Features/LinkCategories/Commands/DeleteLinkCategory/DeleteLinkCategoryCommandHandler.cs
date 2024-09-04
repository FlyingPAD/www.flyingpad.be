using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;

public class DeleteLinkCategoryCommandHandler(IBaseRepository<LinkCategory> linkCategoryRepository) : IRequestHandler<DeleteLinkCategoryCommand, DeleteLinkCategoryCommandResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;

    public async Task<DeleteLinkCategoryCommandResponse> Handle(DeleteLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var linkCategory = await _linkCategoryRepository.GetByBusinessIdAsync(request.LinkCategoryId) ?? throw new NotFoundException($"Link Category with ID {request.LinkCategoryId} was not found.");

        await _linkCategoryRepository.DeleteAsync(linkCategory);

        return new DeleteLinkCategoryCommandResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}