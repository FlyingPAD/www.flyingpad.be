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
        var linkPrimaryId = await _linkRepository.GetPrimaryIdByBusinessIdAsync(request.LinkId);

        if (linkPrimaryId == null)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Link was not found."
            };
        }

        var categoryPrimaryIds = await _linkCategoryRepository.GetPrimaryIdsByBusinessIdsAsync(request.CategoryIds);

        if (categoryPrimaryIds.Count != request.CategoryIds.Count)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "One or more categories were not found."
            };
        }

        await _linkRepository.UpdateCategories((int)linkPrimaryId, categoryPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}