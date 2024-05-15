using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags
{
    public class CreateRelationsMoodTagsCommandHandler(
        CreateRelationsMoodTagsCommandValidator validator,
        IBaseRepository<Mood> moodRepository,
        ITagRepository tagRepository,
        IBaseRepository<RelationMoodTag> relationRepository) : IRequestHandler<CreateRelationsMoodTagsCommand, BaseResponse>
    {
        private readonly CreateRelationsMoodTagsCommandValidator _validator = validator;
        private readonly IBaseRepository<Mood> _moodRepository = moodRepository;
        private readonly ITagRepository _tagRepository = tagRepository;
        private readonly IBaseRepository<RelationMoodTag> _relationRepository = relationRepository;

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

            // Récupération et suppression des Relations existantes pour le MoodId spécifié
            var existingRelations = await _relationRepository.GetAllAsync();
            var relationsToDelete = existingRelations.Where(r => r.MoodId == moodPrimaryId).ToList();
            foreach (var relation in relationsToDelete)
            {
                await _relationRepository.DeleteAsync(relation);
            }

            // Création des nouvelles Relations
            foreach (var tagId in tagsPrimaryIds)
            {
                var newRelation = new RelationMoodTag
                {
                    MoodId = (int)moodPrimaryId,
                    TagId = tagId
                };
                await _relationRepository.CreateAsync(newRelation);
            }

            return new BaseResponse
            {
                Success = true,
                Message = "Relations created successfully."
            };
        }
    }
}