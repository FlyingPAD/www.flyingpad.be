using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.UpdateFranchise;

public class UpdateFranchiseCommandHandler(IMapper mapper, IBaseRepository<Franchise> franchiseRepository) : IRequestHandler<UpdateFranchiseCommand, BaseResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;

    public async Task<BaseResponse> Handle(UpdateFranchiseCommand request, CancellationToken cancellationToken)
    {
        var franchise = await _franchiseRepository.GetByBusinessIdAsync(request.Id);

        if (franchise == null)
        {
            return new BaseResponse { Success = false, Message = "Franchise was not found." };
        }

        _mapper.Map(request, franchise);

        await _franchiseRepository.UpdateAsync(franchise);

        return new BaseResponse
        {
            Success = true,
            Message = "Success.",
        };
    }
}