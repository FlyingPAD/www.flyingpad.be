using MB.Application.Models;

namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;

public class GetTagsCheckBoxesByMoodQueryResponse : BaseResponse
{
    public GetTagsCheckBoxesByMoodQueryDto[] TagsCheckBoxesList { get; set; } = [];
}