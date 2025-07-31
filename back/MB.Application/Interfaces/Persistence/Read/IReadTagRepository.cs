namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadTagRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}