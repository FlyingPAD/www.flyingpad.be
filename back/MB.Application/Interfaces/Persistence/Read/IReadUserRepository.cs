namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadUserRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}