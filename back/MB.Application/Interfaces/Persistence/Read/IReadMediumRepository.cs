namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadMediumRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}