using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.CreateFranchise
{
    public class CreateFranchiseCommandHandler : IRequestHandler<CreateFranchiseCommand, CreateFranchiseCommandResponse>
    {
        private readonly IBaseRepository<Franchise> _franchiseRepository;
        private readonly IMapper _mapper;

        public CreateFranchiseCommandHandler(IMapper mapper, IBaseRepository<Franchise> franchiseRepository)
        {
            _mapper = mapper;
            _franchiseRepository = franchiseRepository;
        }

        public async Task<CreateFranchiseCommandResponse> Handle(CreateFranchiseCommand request, CancellationToken cancellationToken)
        {
            var createFranchiseCommandResponse = new CreateFranchiseCommandResponse();

            var validator = new CreateFranchiseCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createFranchiseCommandResponse.Success = false;
                createFranchiseCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createFranchiseCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createFranchiseCommandResponse.Success)
            {
                var franchise = new Franchise() { Name = request.Name };
                franchise = await _franchiseRepository.CreateAsync(franchise);
                createFranchiseCommandResponse.Franchise = _mapper.Map<CreateFranchiseDto>(franchise);
            }

            return createFranchiseCommandResponse;
        }
    }
}
