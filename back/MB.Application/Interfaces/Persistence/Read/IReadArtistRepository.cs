using System.Threading;

namespace MB.Application.Interfaces.Persistence.Read;

public interface IReadArtistRepository
{
    // Count
    Task<int> CountAsync(CancellationToken cancellationToken);
}