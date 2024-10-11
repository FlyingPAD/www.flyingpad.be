using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Queries.CountTags;

public class CountTagsQueryHandler(IBaseRepository<Tag> tagRepository) : IRequestHandler<CountTagsQuery, CountTagsQueryResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;

    public async Task<CountTagsQueryResponse> Handle(CountTagsQuery request, CancellationToken cancellationToken)
    {
        return new CountTagsQueryResponse
        {
            Success = true,
            Message = "Tags count completed.",
            TotalTags = await _tagRepository.CountAsync()
        };
    }
}