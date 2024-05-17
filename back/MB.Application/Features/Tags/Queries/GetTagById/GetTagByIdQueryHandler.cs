using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagById;

public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<Tag> _tagRepository;

    public GetTagByIdQueryHandler(IMapper mapper, IBaseRepository<Tag> tagRepository)
    {
        _mapper = mapper;
        _tagRepository = tagRepository;
    }

    public async Task<GetTagByIdQueryResponse> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
    {
        var tag = await _tagRepository.GetByBusinessIdAsync(request.TagId);

        if (tag == null)
        {
            return new GetTagByIdQueryResponse { Success = false, Message = "Tag wasn't found :(" };
        }

        var tagVm = _mapper.Map<GetTagByIdVm>(tag);

        return new GetTagByIdQueryResponse
        {
            Success = true,
            Message = "Tag was found :)",
            Tag = tagVm
        };
    }
}
