namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadMoodRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}