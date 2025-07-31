namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadTagCategoryRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}