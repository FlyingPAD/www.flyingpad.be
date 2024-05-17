using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;

public class GetLinkCategoryByIdQueryHandler : IRequestHandler<GetLinkCategoryByIdQuery, GetLinkCategoryByIdQueryResponse>
{
    private readonly IMapper _mapper;
    private IBaseRepository<LinkCategory> _linkCategoryRepository;

    public GetLinkCategoryByIdQueryHandler(IMapper mapper, IBaseRepository<LinkCategory> linkCategoryRepository)
    {
        _mapper = mapper;
        _linkCategoryRepository = linkCategoryRepository;
    }

    public async Task<GetLinkCategoryByIdQueryResponse> Handle(GetLinkCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var linkCategory = await _linkCategoryRepository.GetByBusinessIdAsync(request.LinkCategoryId);

        if (linkCategory == null)
        {
            return new GetLinkCategoryByIdQueryResponse { Success = false, Message = "LinkCategory wasn't found :(" };
        }

        var linkCategoryVm = _mapper.Map<GetLinkCategoryByIdVm>(linkCategory);

        return new GetLinkCategoryByIdQueryResponse
        {
            Success = true,
            Message = "LinkCategory was found :)",
            LinkCategory = linkCategoryVm
        };
    }
}
