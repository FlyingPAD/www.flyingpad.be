using MB.Application.Features.Artists.Queries.CountArtists;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Tests.Features.Artists.Queries;

public class CountArtistsQueryHandlerTests
{
    private readonly Mock<IBaseRepository<Artist>> _artistRepositoryMock;
    private readonly CountArtistsQueryHandler _handler;

    public CountArtistsQueryHandlerTests()
    {
        _artistRepositoryMock = new Mock<IBaseRepository<Artist>>();

        _handler = new CountArtistsQueryHandler(_artistRepositoryMock.Object);
    }

    [Fact]
    [Trait("Features", "Artists")]
    public async System.Threading.Tasks.Task HandleShouldReturnCorrectCount()
    {
        var expectedCount = 10;
        _artistRepositoryMock.Setup(repo => repo.CountAsync())
                             .ReturnsAsync(expectedCount);

        var query = new CountArtistsQuery();
        var cancellationToken = new CancellationToken();

        var result = await _handler.Handle(query, cancellationToken);

        Assert.True(result.Success);
        Assert.Equal($"Total Artists : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.ArtistsCount);

        _artistRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }

    [Fact]
    [Trait("Features", "Artists")]
    public async System.Threading.Tasks.Task HandleShouldReturnZeroCount()
    {
        var expectedCount = 0;
        _artistRepositoryMock.Setup(repo => repo.CountAsync())
                             .ReturnsAsync(expectedCount);

        var query = new CountArtistsQuery();
        var cancellationToken = new CancellationToken();

        var result = await _handler.Handle(query, cancellationToken);

        Assert.True(result.Success);
        Assert.Equal($"Total Artists : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.ArtistsCount);

        _artistRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }

    [Fact]
    [Trait("Features", "Artists")]
    public async System.Threading.Tasks.Task HandleShouldThrowExceptionWhenRepositoryFails()
    {
        _artistRepositoryMock.Setup(repo => repo.CountAsync())
                             .ThrowsAsync(new Exception("Repository failure"));

        var query = new CountArtistsQuery();
        var cancellationToken = new CancellationToken();

        await Assert.ThrowsAsync<Exception>(() => _handler.Handle(query, cancellationToken));

        _artistRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}