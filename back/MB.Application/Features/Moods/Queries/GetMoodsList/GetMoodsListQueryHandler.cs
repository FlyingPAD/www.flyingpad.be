using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsList;

public class GetMoodsListQueryHandler(IBaseRepository<Mood> moodRepository, IMapper mapper) : IRequestHandler<GetMoodsListQuery, GetMoodsListQueryResponse>
{
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetMoodsListQueryResponse> Handle(GetMoodsListQuery request, CancellationToken cancellationToken)
    {
        var moods = await _moodRepository.GetAllAsync(mood => mood.Score, false);

        var response = new GetMoodsListQueryResponse
        {
            Success = true,
            Message = "Success.",
            Moods = _mapper.Map<List<MoodListVm>>(moods)
        };

        return response;
    }
}