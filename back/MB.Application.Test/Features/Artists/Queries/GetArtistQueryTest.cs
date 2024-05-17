using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Artists.Queries.GetArtist;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Artists.Queries;

public class GetArtistQueryTest
{
    private Mock<IMapper> _mapperMock;
    private Mock<IBaseRepository<Artist>> _artistRepositoryMock;
    private GetArtistQueryValidator _validator;
    private GetArtistQueryHandler _handler;

    public GetArtistQueryTest()
    {
        _mapperMock = new Mock<IMapper>();
        _artistRepositoryMock = new Mock<IBaseRepository<Artist>>();
        _validator = new GetArtistQueryValidator();
        _handler = new GetArtistQueryHandler(_mapperMock.Object, _artistRepositoryMock.Object, _validator);
    }
}
