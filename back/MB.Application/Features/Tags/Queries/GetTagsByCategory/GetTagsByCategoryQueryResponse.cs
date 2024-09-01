using MB.Application.Models;

namespace MB.Application.Features.Tags.Queries.GetTagsByCategory
{
    public class GetTagsByCategoryQueryResponse : BaseResponse
    {
        public List<GetTagsByCategoryQueryDto> Tags { get; set; } = [];
    }
}