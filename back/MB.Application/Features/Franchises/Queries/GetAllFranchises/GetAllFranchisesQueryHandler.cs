using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GetAllFranchisesQueryHandler(IBaseRepository<Franchise> franchiseRepository, IMapper mapper) : IRequestHandler<GetAllFranchisesQuery, GetAllFranchisesQueryResponse>
{
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllFranchisesQueryResponse> Handle(GetAllFranchisesQuery request, CancellationToken cancellationToken)
    {
        var franchises = await _franchiseRepository.GetAllAsync();

        var response = new GetAllFranchisesQueryResponse
        {
            Success = true,
            Message = "Success.",
            Franchises = _mapper.Map<List<GetAllFranchisesQueryVm>>(franchises)
        };

        return response;
    }
}