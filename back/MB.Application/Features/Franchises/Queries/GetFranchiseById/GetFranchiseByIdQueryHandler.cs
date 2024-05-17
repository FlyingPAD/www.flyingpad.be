using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchiseById;

public class GetFranchiseByIdQueryHandler(IMapper mapper, IBaseRepository<Franchise> franchiseRepository) : IRequestHandler<GetFranchiseByIdQuery, GetFranchiseByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;

    public async Task<GetFranchiseByIdQueryResponse> Handle(GetFranchiseByIdQuery request, CancellationToken cancellationToken)
    {
        var franchise = await _franchiseRepository.GetByBusinessIdAsync(request.BusinessId);

        if (franchise == null)
        {
            return new GetFranchiseByIdQueryResponse { Success = false, Message = "Franchise wasn't found :(" };
        }

        return new GetFranchiseByIdQueryResponse
        {
            Success = true,
            Message = "Franchise was found :)",
            Franchise = _mapper.Map<GetFranchiseByIdVm>(franchise)
        };
    }
}