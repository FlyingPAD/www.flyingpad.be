using MB.Application.Interfaces.Services;

namespace MB.Infrastructure.Jobs;

public class ProcessSeasonsJob(ISeasonService service)
{
    private readonly ISeasonService _service = service;

    public Task ExecuteAsync() => _service.ProcessSeasonsAsync();
}