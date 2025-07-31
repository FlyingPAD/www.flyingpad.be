namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadLinkRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}