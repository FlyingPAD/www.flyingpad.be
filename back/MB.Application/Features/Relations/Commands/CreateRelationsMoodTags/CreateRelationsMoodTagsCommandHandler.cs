using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags;

public class CreateRelationsMoodTagsCommandHandler(IMoodRepository moodRepository, ITagRepository tagRepository) : IRequestHandler<CreateRelationsMoodTagsCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<BaseResponse> Handle(CreateRelationsMoodTagsCommand request, CancellationToken cancellationToken)
    {
        var moodId = await _moodRepository.GetEntityIdByBusinessIdAsync(request.MoodId, cancellationToken)
            ?? throw new NotFoundException("Mood not found.");

        var tagsPrimaryIds = await _tagRepository.GetPrimaryIdsByBusinessIdsAsync(request.TagIds);

        if (tagsPrimaryIds.Count != request.TagIds.Count)
        {
            throw new NotFoundException("One or more tags were not found.");
        }

        await _moodRepository.UpdateTags(moodId, tagsPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Tags updated."
        };
    }
}