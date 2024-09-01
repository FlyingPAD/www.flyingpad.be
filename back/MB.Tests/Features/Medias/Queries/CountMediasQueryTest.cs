using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Medias.Queries.CountMedias;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Medias.Queries;

public class CountMediasQueryTest
{
    private Mock<IBaseRepository<Media>> _mediaRepositoryMock;
    private CountMediasQueryHandler _handler;

    public CountMediasQueryTest()
    {
        _mediaRepositoryMock = new Mock<IBaseRepository<Media>>();
        _handler = new CountMediasQueryHandler(_mediaRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _mediaRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountMediasQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Medias : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.MediasCount);

        _mediaRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}