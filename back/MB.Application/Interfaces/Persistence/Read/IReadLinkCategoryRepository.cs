namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadLinkCategoryRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}