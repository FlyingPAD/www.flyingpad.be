using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Domain.MoodAggregate;
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
            Message = "Image Details",
            Image = imageVm
        };
    }
}