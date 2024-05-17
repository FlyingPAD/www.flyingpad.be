using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Queries.CountTags;

public class CountTagsQueryHandler : IRequestHandler<CountTagsQuery, CountTagsQueryResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository;

    public CountTagsQueryHandler(IBaseRepository<Tag> tagRepository)
    {
        _tagRepository = tagRepository;
    }

    public async Task<CountTagsQueryResponse> Handle(CountTagsQuery request, CancellationToken cancellationToken)
    {
        var tagsCount = await _tagRepository.CountAsync();

        return new CountTagsQueryResponse
        {
            Success = true,
            Message = $"Total Tags : {tagsCount}",
            TagsCount = tagsCount
        };
    }
}