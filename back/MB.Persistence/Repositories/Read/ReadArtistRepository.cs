using System.Threading;
using MB.Application.Interfaces.Persistence.Read;
using MB.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Read;

public class ReadArtistRepository(ReadContext context) : IReadArtistRepository
{
    private readonly ReadContext _context = context;

    public Task<int> CountAsync(CancellationToken cancellationToken)
    {
        return _context.Artists.CountAsync(cancellationToken);
    }
}