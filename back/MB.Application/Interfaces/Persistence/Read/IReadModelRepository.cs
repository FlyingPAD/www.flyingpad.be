namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadModelRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}