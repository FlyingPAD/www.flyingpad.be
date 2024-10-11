using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;

public class UpdateLinkCategoryCommandHandler(IMapper mapper, IBaseRepository<LinkCategory> linkCategoryRepository) : IRequestHandler<UpdateLinkCategoryCommand, BaseResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;

    public async Task<BaseResponse> Handle(UpdateLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var linkCategory = await _linkCategoryRepository.GetByBusinessIdAsync(request.LinkCategoryId)
            ?? throw new NotFoundException("Link category not found.");

        _mapper.Map(request, linkCategory);

        await _linkCategoryRepository.UpdateAsync(linkCategory);

        return new BaseResponse
        {
            Success = true,
            Message = "Link category was updated.",
        };
    }
}