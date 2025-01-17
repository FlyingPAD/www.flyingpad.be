using MB.Application.Models;

namespace MB.Application.Features.Statistics.Queries.GetStatistics;

public class GetStatisticsQueryResponse : BaseResponse
{
    public GetStatisticsQueryDto Statistics { get; set; } = new GetStatisticsQueryDto();
}