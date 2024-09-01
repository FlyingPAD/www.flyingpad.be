using MB.Application.Contracts.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags;

public class CreateRelationsMoodTagsCommandHandler(CreateRelationsMoodTagsCommandValidator validator, IMoodRepository moodRepository, ITagRepository tagRepository) : IRequestHandler<CreateRelationsMoodTagsCommand, BaseResponse>
{
    private readonly CreateRelationsMoodTagsCommandValidator _validator = validator;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<BaseResponse> Handle(CreateRelationsMoodTagsCommand request, CancellationToken cancellationToken)
    {
        // Validation de la requête
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count > 0)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Validation Error(s)",
                ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
            };
        }

        // Recherche de l'ID primaire du Mood
        var moodPrimaryId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId);
        if (moodPrimaryId == null)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Mood was not found."
            };
        }

        // Récupération des IDs primaires des Tags
        var tagsPrimaryIds = await _tagRepository.GetPrimaryIdsByBusinessIdsAsync(request.TagIds);
        if (tagsPrimaryIds.Count != request.TagIds.Count)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "One or more tags were not found."
            };
        }

        // Mise à jour des Tags
        await _moodRepository.UpdateTags((int)moodPrimaryId, tagsPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}