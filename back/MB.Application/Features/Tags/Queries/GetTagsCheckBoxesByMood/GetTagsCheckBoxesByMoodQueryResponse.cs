using MB.Application.Responses;

namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood
{
    public class GetTagsCheckBoxesByMoodQueryResponse : BaseResponse
    {
        public GetTagsCheckBoxesListDto[] TagsCheckBoxesList { get; set; } = [];
    }
}
