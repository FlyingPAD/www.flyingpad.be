using MB.Application.Interfaces.Persistence;
using MB.Domain.ArtistAggregate;
using MediatR;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByArtist;

public class CheckRelationsArtistStyleByArtistQueryHandler(IBaseRepository<RelationArtistStyle> relationRepository, IBaseRepository<Artist> artistRepository) : IRequestHandler<CheckRelationsArtistStyleByArtistQuery, CheckRelationsArtistStyleByArtistQueryResponse>
{
    private readonly IBaseRepository<RelationArtistStyle> _relationRepository = relationRepository;
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;

    public async Task<CheckRelationsArtistStyleByArtistQueryResponse> Handle(CheckRelationsArtistStyleByArtistQuery request, CancellationToken cancellationToken)
    {
        int? artistPrimaryId = await _artistRepository.GetEntityIdByBusinessIdAsync(request.ArtistId, cancellationToken);

        if (!artistPrimaryId.HasValue)
        {
            return new CheckRelationsArtistStyleByArtistQueryResponse
            {
                Success = false,
                Message = "Artist was not found."
            };
        }

        int numberOfRelations = await _relationRepository.CountAsync();

        return new CheckRelationsArtistStyleByArtistQueryResponse
        {
            Success = true,
            Message = $"Number of artist-style relations : {numberOfRelations}",
            NumberOfRelations = numberOfRelations
        };
    }
}