﻿using MB.Application.Features.Medias.Queries;
using MB.Domain.MediumAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface IMediaRepository : IBaseRepository<Media>
{
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
    Task<IEnumerable<GetMediaCheckBoxesByFranchiseQueryDto>> GetCheckBoxesByFranchise(int franchiseId);
}