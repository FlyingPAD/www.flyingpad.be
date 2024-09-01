using MB.Application.Contracts.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodArtist;

public class CreateRelationsMoodArtistCommandHandler(CreateRelationsMoodArtistCommandValidator validator, IMoodRepository moodRepository, IArtistRepository artistRepository) : IRequestHandler<CreateRelationsMoodArtistCommand, BaseResponse>
{
    private readonly CreateRelationsMoodArtistCommandValidator _validator = validator;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IArtistRepository _artistRepository = artistRepository;

    public async Task<BaseResponse> Handle(CreateRelationsMoodArtistCommand request, CancellationToken cancellationToken)
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

        var moodPrimaryId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId);
        if (moodPrimaryId == null)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Mood was not found."
            };
        }

        var artistsPrimaryIds = await _artistRepository.GetPrimaryIdsByBusinessIdsAsync(request.ArtistIds);
        if (artistsPrimaryIds.Count != request.ArtistIds.Count)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "One or more artists were not found."
            };
        }

        await _moodRepository.UpdateArtists((int)moodPrimaryId, artistsPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}
