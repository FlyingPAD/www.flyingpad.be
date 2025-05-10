using MB.Application.Features.Statistics.Queries.GetStatistics;

namespace MB.Application.Models;

public class DailyReportModel : GetStatisticsQueryDto
{
    public int ExpiredTokenCount { get; set; }
}