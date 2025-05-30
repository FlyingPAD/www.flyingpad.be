using MB.Application.Interfaces.Persistence.Definitions;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.MultiTags
{
    public class MultiTagsCommandHandler(IMoodRepository moodRepository) : IRequestHandler<MultiTagsCommand, BaseResponse>
    {
        private readonly IMoodRepository _moodRepository = moodRepository;

        public async Task<BaseResponse> Handle(MultiTagsCommand request, CancellationToken cancellationToken)
        {
            await _moodRepository.UpdateMultiTags(request.MoodIds, request.TagsToAdd, request.TagsToRemove);

            return new BaseResponse
            {
                Success = true,
                Message = "Common tags updated."
            };
        }
    }
}