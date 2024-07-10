using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Commands.RAS;

public class CreateRelationsArtistStyleCommandHandler : IRequestHandler<CreateRelationsArtistStyleCommand, BaseResponse>
{
    private readonly CreateRelationsArtistStyleCommandValidator _validator;
    private readonly IBaseRepository<Artist> _artistRepository;
    private readonly IStyleRepository _styleRepository;
    private readonly IBaseRepository<RelationArtistStyle> _relationRepository;

    public CreateRelationsArtistStyleCommandHandler(CreateRelationsArtistStyleCommandValidator validator, IBaseRepository<Artist> artistRepository, IStyleRepository styleRepository, IBaseRepository<RelationArtistStyle> relationRepository)
    {
        _validator = validator;
        _artistRepository = artistRepository;
        _styleRepository = styleRepository;
        _relationRepository = relationRepository;
    }

    public async Task<BaseResponse> Handle(CreateRelationsArtistStyleCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count != 0)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Validation Error(s)",
                ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
            };
        }

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