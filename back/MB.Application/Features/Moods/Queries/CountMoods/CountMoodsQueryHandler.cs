using MB.Application.Interfaces.Persistence;
using MB.Domain.MoodAggregate;
using MediatR;

namespace MB.Application.Features.Moods.Queries.CountMoods;

public class CountMoodsQueryHandler(IBaseRepository<Mood> moodRepository) : IRequestHandler<CountMoodsQuery, CountMoodsQueryResponse>
{
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;

    public async Task<CountMoodsQueryResponse> Handle(CountMoodsQuery request, CancellationToken cancellationToken)
    {
        return new CountMoodsQueryResponse
        {
            Success = true,
            Message = "Moods count completed.",
            TotalMoods = await _moodRepository.CountAsync()
        };
    }
}