using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;

public class GetLinkCategoryByIdQueryHandler(IMapper mapper, IBaseRepository<LinkCategory> linkCategoryRepository) : IRequestHandler<GetLinkCategoryByIdQuery, GetLinkCategoryByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;

    public async Task<GetLinkCategoryByIdQueryResponse> Handle(GetLinkCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var linkCategory = await _linkCategoryRepository.GetByBusinessIdAsync(request.LinkCategoryId)
            ?? throw new NotFoundException("Link category not found.");

        return new GetLinkCategoryByIdQueryResponse
        {
            Success = true,
            Message = $"{linkCategory.Name}.",
            LinkCategory = _mapper.Map<GetLinkCategoryByIdQueryDto>(linkCategory)
        };
    }
}