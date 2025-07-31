using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Domain.FranchiseAggregate;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetAllFranchises;

public class GetAllFranchisesQueryHandler(IBaseRepository<Franchise> franchiseRepository, IMapper mapper) : IRequestHandler<GetAllFranchisesQuery, GetAllFranchisesQueryResponse>
{
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllFranchisesQueryResponse> Handle(GetAllFranchisesQuery request, CancellationToken cancellationToken)
    {
        var franchises = await _franchiseRepository.GetAllAsync(franchise => franchise.Name);

        return new GetAllFranchisesQueryResponse
        {
            Success = true,
            Message = "All franchises.",
            Franchises = _mapper.Map<List<GetAllFranchisesQueryDto>>(franchises)
        };
    }
}