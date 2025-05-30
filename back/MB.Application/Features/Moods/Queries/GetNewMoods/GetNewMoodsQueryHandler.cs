using MB.Application.Exceptions;
using MB.Application.Features.Moods.Mapper;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetNewMoods;

public class GetNewMoodsQueryHandler(IMoodRepository _moodRepo) : IRequestHandler<GetNewMoodsQuery, GetNewMoodsQueryResponse>
{
    private readonly IMoodRepository moodRepo = _moodRepo;

    public async Task<GetNewMoodsQueryResponse> Handle(GetNewMoodsQuery request, CancellationToken cancellationToken)
    {
        var moods = await moodRepo.GetNewMoodsAsync(cancellationToken) ?? throw new NotFoundException("No moods found.");

        var dtos = MoodMapper.ToListItemDtos(moods);

        return new GetNewMoodsQueryResponse
        {
            Success = true,
            Message = "New Moods.",
            Moods = dtos
        };
    }
}