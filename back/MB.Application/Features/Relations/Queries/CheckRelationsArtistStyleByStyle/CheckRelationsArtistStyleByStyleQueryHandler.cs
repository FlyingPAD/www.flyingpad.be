using MB.Application.Interfaces.Persistence;
using MB.Domain.ArtistAggregate;
using MB.Domain.StyleAggregate;
using MediatR;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByStyle;

public class CheckRelationsArtistStyleByStyleQueryHandler(IBaseRepository<RelationArtistStyle> relationRepository, IBaseRepository<Style> styleRepository) : IRequestHandler<CheckRelationsArtistStyleByStyleQuery, CheckRelationsArtistStyleByStyleQueryResponse>
{
    private readonly IBaseRepository<RelationArtistStyle> _relationRepository = relationRepository;
    private readonly IBaseRepository<Style> _styleRepository = styleRepository;

    public async Task<CheckRelationsArtistStyleByStyleQueryResponse> Handle(CheckRelationsArtistStyleByStyleQuery request, CancellationToken cancellationToken)
    {
        int? stylePrimaryId = await _styleRepository.GetPrimaryIdByBusinessIdAsync(request.StyleId);

        if (!stylePrimaryId.HasValue)
        {
            return new CheckRelationsArtistStyleByStyleQueryResponse
            {
                Success = false,
                Message = "Style was not found."
            };
        }

        int numberOfRelations = await _relationRepository.CountAsync();

        return new CheckRelationsArtistStyleByStyleQueryResponse
        {
            Success = true,
            Message = $"Number of artist-style relations for the style: {numberOfRelations}",
            NumberOfRelations = numberOfRelations
        };
    }
}