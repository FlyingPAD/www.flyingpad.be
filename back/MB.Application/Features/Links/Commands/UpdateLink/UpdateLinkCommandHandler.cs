using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Commands.UpdateLink
{
    public class UpdateLinkCommandHandler : IRequestHandler<UpdateLinkCommand, UpdateLinkCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Link> _linkRepository;

        public UpdateLinkCommandHandler(IMapper mapper, IBaseRepository<Link> linkRepository)
        {
            _mapper = mapper;
            _linkRepository = linkRepository;
        }

        public async Task<UpdateLinkCommandResponse> Handle(UpdateLinkCommand request, CancellationToken cancellationToken)
        {
            var link = await _linkRepository.GetByBusinessIdAsync(request.Id);

            if (link == null)
            {
                return new UpdateLinkCommandResponse { Success = false, Message = "Link wasn't found :(" };
            }

            _mapper.Map(request, link);

            await _linkRepository.UpdateAsync(link);

            var updatedLinkDto = _mapper.Map<UpdateLinkDto>(link);

            return new UpdateLinkCommandResponse
            {
                Success = true,
                Message = "Link was Updated :)",
                UpdatedLink = updatedLinkDto
            };
        }

    }
}
