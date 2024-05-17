using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Images.Queries;

public class GetOneImageDetailsQueryHandler(IMapper mapper, IBaseRepository<Image> imageRepository) : IRequestHandler<GetOneImageDetailsQuery, GetOneImageDetailsQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Image> _imageRepository = imageRepository;

    public async Task<GetOneImageDetailsQueryResponse> Handle(GetOneImageDetailsQuery request, CancellationToken cancellationToken)
    {
        var image = await _imageRepository.GetByBusinessIdAsync(request.ImageId);

        if (image == null)
        {
            return new GetOneImageDetailsQueryResponse { Success = false, Message = "Image wasn't found :(" };
        }

        var imageVm = _mapper.Map<GetOneImageDetailsQueryVm>(image);

        return new GetOneImageDetailsQueryResponse
        {
            Success = true,
            Message = "Mood was found :)",
            Image = imageVm
        };
    }
}