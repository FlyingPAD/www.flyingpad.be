using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsLinkCategory;

public class CreateRelationsLinkCategoryCommandHandler(ILinkRepository linkRepository, ILinkCategoryRepository linkCategoryRepository) : IRequestHandler<CreateRelationsLinkCategoryCommand, BaseResponse>
{
    private readonly ILinkRepository _linkRepository = linkRepository;
    private readonly ILinkCategoryRepository _linkCategoryRepository = linkCategoryRepository;

    public async Task<BaseResponse> Handle(CreateRelationsLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var linkId = await _linkRepository.GetPrimaryIdByBusinessIdAsync(request.LinkId)
            ?? throw new NotFoundException("Link not found.");

        var categoryIds = await _linkCategoryRepository.GetPrimaryIdsByBusinessIdsAsync(request.CategoryIds);

        if (categoryIds.Count != request.CategoryIds.Count)
        {
            throw new NotFoundException("One or more categories were not found.");
        }

        await _linkRepository.UpdateCategories(linkId, categoryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}