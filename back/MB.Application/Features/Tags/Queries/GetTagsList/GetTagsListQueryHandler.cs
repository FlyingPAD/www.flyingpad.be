using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsList;

public class GetTagsListQueryHandler(IBaseRepository<Tag> tagRepository, IMapper mapper) : IRequestHandler<GetTagsListQuery, GetTagsListQueryResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetTagsListQueryResponse> Handle(GetTagsListQuery request, CancellationToken cancellationToken)
    {
        var tags = await _tagRepository.GetAllAsync(x => x.Name);

        var response = new GetTagsListQueryResponse
        {
            Success = true,
            Message = "Here are the Tags !",
            Tags = _mapper.Map<List<TagListVm>>(tags)
        };

        return response;
    }
}