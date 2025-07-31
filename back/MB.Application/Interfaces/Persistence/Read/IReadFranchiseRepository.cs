namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadFranchiseRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}