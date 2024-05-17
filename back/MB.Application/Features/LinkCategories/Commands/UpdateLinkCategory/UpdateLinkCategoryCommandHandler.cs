using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;

public class UpdateLinkCategoryCommandHandler : IRequestHandler<UpdateLinkCategoryCommand, UpdateLinkCategoryCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository;

    public UpdateLinkCategoryCommandHandler(IMapper mapper, IBaseRepository<LinkCategory> linkCategoryRepository)
    {
        _mapper = mapper;
        _linkCategoryRepository = linkCategoryRepository;
    }

    public async Task<UpdateLinkCategoryCommandResponse> Handle(UpdateLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var linkCategory = await _linkCategoryRepository.GetByBusinessIdAsync(request.Id);

        if (linkCategory == null)
        {
            return new UpdateLinkCategoryCommandResponse { Success = false, Message = "LinkCategory wasn't found :(" };
        }

        _mapper.Map(request, linkCategory);

        await _linkCategoryRepository.UpdateAsync(linkCategory);

        var updatedLinkCategoryDto = _mapper.Map<UpdateLinkCategoryDto>(linkCategory);

        return new UpdateLinkCategoryCommandResponse
        {
            Success = true,
            Message = "LinkCategory was Updated :)",
            UpdatedLinkCategory = updatedLinkCategoryDto
        };
    }

}
