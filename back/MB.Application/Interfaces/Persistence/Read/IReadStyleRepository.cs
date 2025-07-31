namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadStyleRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}