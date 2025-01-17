using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetAllMoods;

public class GetAllMoodsQueryHandler(IBaseRepository<Mood> moodRepository, IMapper mapper) : IRequestHandler<GetAllMoodsQuery, GetAllMoodsQueryResponse>
{
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllMoodsQueryResponse> Handle(GetAllMoodsQuery request, CancellationToken cancellationToken)
    {
        var moods = await _moodRepository.GetAllAsync(shuffle: true);

        return new GetAllMoodsQueryResponse
        {
            Success = true,
            Message = "All moods.",
            Moods = _mapper.Map<List<GetAllMoodsQueryDto>>(moods)
        };
    }
}