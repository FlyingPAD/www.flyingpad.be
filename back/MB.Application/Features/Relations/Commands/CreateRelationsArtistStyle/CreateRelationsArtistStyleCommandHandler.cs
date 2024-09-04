using MB.Application.Features.Relations.Commands.RAS;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsArtistStyle;

public class CreateRelationsArtistStyleCommandHandler(IBaseRepository<Artist> artistRepository, IStyleRepository styleRepository, IBaseRepository<RelationArtistStyle> relationRepository) : IRequestHandler<CreateRelationsArtistStyleCommand, BaseResponse>
{
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
    private readonly IStyleRepository _styleRepository = styleRepository;
    private readonly IBaseRepository<RelationArtistStyle> _relationRepository = relationRepository;

    public async Task<BaseResponse> Handle(CreateRelationsArtistStyleCommand request, CancellationToken cancellationToken)
    {
        var artistPrimaryId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.ArtistId);

        if (artistPrimaryId == null)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Artist was not found."
            };
        }

        var stylePrimaryIds = await _styleRepository.GetPrimaryIdsByBusinessIdsAsync(request.StyleIds);

        if (stylePrimaryIds.Count != request.StyleIds.Count)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "One or more styles were not found."
            };
        }

        foreach (var styleId in stylePrimaryIds)
        {
            var relation = new RelationArtistStyle
            {
                ArtistId = artistPrimaryId.Value,
                StyleId = styleId
            };
            await _relationRepository.CreateAsync(relation);
        }

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}