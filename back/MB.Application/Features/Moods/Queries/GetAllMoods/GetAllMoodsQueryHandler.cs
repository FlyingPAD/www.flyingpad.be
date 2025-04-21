using MB.Application.Features.Moods.Mapper;
using MB.Application.Features.Moods.Queries;
using MB.Application.Interfaces.Persistence;
using MB.Domain.MoodAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MB.Application.Features.Moods.Queries.GetAllMoods;

public class GetAllMoodsQueryHandler(IBaseRepository<Mood> moodRepository) : IRequestHandler<GetAllMoodsQuery, GetAllMoodsQueryResponse>
{
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;

    public async Task<GetAllMoodsQueryResponse> Handle(GetAllMoodsQuery request, CancellationToken cancellationToken)
    {
        var moods = await _moodRepository
            .GetAllAsync(shuffle: true)
            .Result
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        var dtos = MoodMapper.ToListItemDtos(moods);

        return new GetAllMoodsQueryResponse
        {
            Success = true,
            Message = "All moods.",
            Moods = dtos
        };
    }
}