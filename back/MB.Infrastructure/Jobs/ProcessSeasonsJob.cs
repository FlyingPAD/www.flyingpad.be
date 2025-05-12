using Hangfire;
using MB.Application.Interfaces.Services;

namespace MB.Infrastructure.Jobs;

public class ProcessSeasonsJob(ISeasonService service)
{
    private readonly ISeasonService _service = service;

    [AutomaticRetry(Attempts = 3)]
    public Task ExecuteAsync()
        => _service.ProcessSeasonsAsync();
}