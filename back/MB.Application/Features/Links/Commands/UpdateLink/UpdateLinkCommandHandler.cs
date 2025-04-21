using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Links.Commands.UpdateLink;

public class UpdateLinkCommandHandler(ILinkRepository linkRepository, ILinkCategoryRepository linkCategoryRepository) : IRequestHandler<UpdateLinkCommand, BaseResponse>
{
    private readonly ILinkRepository _linkRepository = linkRepository;
    private readonly ILinkCategoryRepository _linkCategoryRepository = linkCategoryRepository;

    public async Task<BaseResponse> Handle(UpdateLinkCommand request, CancellationToken cancellationToken)
    {
        var linkId = await _linkRepository.GetPrimaryIdByBusinessIdAsync(request.LinkId)
            ?? throw new NotFoundException("Link not found.");

        var link = await _linkRepository.GetLinkWithCategoriesAsync(linkId)
            ?? throw new NotFoundException("Link not found.");

        link.Name = request.Name;
        link.Description = request.Description;
        link.Url = request.Url;

        await _linkRepository.UpdateAsync(link);

        await _linkRepository.RemoveLinkCategoriesAsync(link);

        var categoryIds = await _linkCategoryRepository.GetPrimaryIdsByBusinessIdsAsync(request.LinkCategoryIds);

        if (categoryIds.Count != request.LinkCategoryIds.Count)
        {
            throw new NotFoundException("One or more categories were not found.");
        }

        await _linkRepository.AddLinkCategoriesAsync(linkId, categoryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Link was updated."
        };
    }
}