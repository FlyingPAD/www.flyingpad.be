using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Queries.CountMoods
{
    public class CountMoodsQueryHandler : IRequestHandler<CountMoodsQuery, CountMoodsQueryResponse>
    {
        private readonly IBaseRepository<Mood> _moodRepository;

        public CountMoodsQueryHandler(IBaseRepository<Mood> moodRepository)
        {
            _moodRepository = moodRepository;
        }

        public async Task<CountMoodsQueryResponse> Handle(CountMoodsQuery request, CancellationToken cancellationToken)
        {
            var moodsCount = await _moodRepository.CountAsync();

            return new CountMoodsQueryResponse
            {
                Success = true,
                Message = $"Total Moods : {moodsCount}",
                MoodsCount = moodsCount
            };
        }
    }
}
