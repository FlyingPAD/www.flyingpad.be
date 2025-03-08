using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTagCategory;

public class GetMoodsByTagCategoryQuery : IRequest<GetMoodsByTagCategoryQueryResponse>
{
    public Guid TagCategoryId { get; set; }
}