using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.UpdateFranchise
{
    public class UpdateFranchiseCommandHandler : IRequestHandler<UpdateFranchiseCommand, UpdateFranchiseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Franchise> _franchiseRepository;

        public UpdateFranchiseCommandHandler(IMapper mapper, IBaseRepository<Franchise> franchiseRepository)
        {
            _mapper = mapper;
            _franchiseRepository = franchiseRepository;
        }

        public async Task<UpdateFranchiseCommandResponse> Handle(UpdateFranchiseCommand request, CancellationToken cancellationToken)
        {
            var franchise = await _franchiseRepository.GetByBusinessIdAsync(request.Id);

            if (franchise == null)
            {
                return new UpdateFranchiseCommandResponse { Success = false, Message = "Franchise wasn't found :(" };
            }

            _mapper.Map(request, franchise);

            await _franchiseRepository.UpdateAsync(franchise);

            var updatedFranchiseDto = _mapper.Map<UpdateFranchiseDto>(franchise);

            return new UpdateFranchiseCommandResponse
            {
                Success = true,
                Message = "Franchise was Updated :)",
                UpdatedFranchise = updatedFranchiseDto
            };
        }

    }
}
