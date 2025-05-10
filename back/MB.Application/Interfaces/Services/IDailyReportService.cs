using MB.Application.Models;

namespace MB.Application.Interfaces.Services;

public interface IDailyReportService
{
    Task<DailyReportModel> GenerateReportAsync();
}