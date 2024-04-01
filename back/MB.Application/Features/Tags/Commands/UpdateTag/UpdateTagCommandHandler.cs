using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Commands.UpdateTag
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, UpdateTagCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Tag> _tagRepository;

        public UpdateTagCommandHandler(IMapper mapper, IBaseRepository<Tag> tagRepository)
        {
            _mapper = mapper;
            _tagRepository = tagRepository;
        }

        public async Task<UpdateTagCommandResponse> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var tag = await _tagRepository.GetByBusinessIdAsync(request.Id);

            if (tag == null)
            {
                return new UpdateTagCommandResponse { Success = false, Message = "Tag wasn't found :(" };
            }

            _mapper.Map(request, tag);

            await _tagRepository.UpdateAsync(tag);

            var updatedTagDto = _mapper.Map<UpdateTagDto>(tag);

            return new UpdateTagCommandResponse
            {
                Success = true,
                Message = "Tag was Updated :)",
                UpdatedTag = updatedTagDto
            };
        }

    }
}
