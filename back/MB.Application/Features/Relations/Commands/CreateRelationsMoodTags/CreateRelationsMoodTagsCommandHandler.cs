using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags;

public class CreateRelationsMoodTagsCommandHandler(IMoodRepository moodRepository, ITagRepository tagRepository) : IRequestHandler<CreateRelationsMoodTagsCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<BaseResponse> Handle(CreateRelationsMoodTagsCommand request, CancellationToken cancellationToken)
    {
        var moodPrimaryId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId);

        if (moodPrimaryId == null)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Mood was not found."
            };
        }

        var tagsPrimaryIds = await _tagRepository.GetPrimaryIdsByBusinessIdsAsync(request.TagIds);

        if (tagsPrimaryIds.Count != request.TagIds.Count)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "One or more tags were not found."
            };
        }

        await _moodRepository.UpdateTags((int)moodPrimaryId, tagsPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}