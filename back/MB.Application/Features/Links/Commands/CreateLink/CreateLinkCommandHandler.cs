using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommandHandler(ILinkRepository linkRepository, ILinkCategoryRepository linkCategoryRepository) : IRequestHandler<CreateLinkCommand, CreateLinkCommandResponse>
{
    private readonly ILinkRepository _linkRepository = linkRepository;
    private readonly ILinkCategoryRepository _linkCategoryRepository = linkCategoryRepository;

    public async Task<CreateLinkCommandResponse> Handle(CreateLinkCommand request, CancellationToken cancellationToken)
    {
        var link = new Link
        {
            Name = request.Name,
            Description = request.Description,
            Url = request.Url
        };

        link = await _linkRepository.CreateAsync(link);

        var categoryIds = await _linkCategoryRepository.GetPrimaryIdsByBusinessIdsAsync(request.LinkCategories);

        if (categoryIds.Count != request.LinkCategories.Count)
        {
            throw new NotFoundException("One or more categories were not found.");
        }

        await _linkRepository.UpdateCategories(link.EntityId, categoryIds);

        return new CreateLinkCommandResponse
        {
            Success = true,
            Message = "Creation successful.",
            LinkId = link.BusinessId
        };
    }
}