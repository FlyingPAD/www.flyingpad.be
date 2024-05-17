using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Links.Queries.CountLinks;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Links.Queries;

public class CountLinksQueryTest
{
    private Mock<IBaseRepository<Link>> _linkRepositoryMock;
    private CountLinksQueryHandler _handler;

    public CountLinksQueryTest()
    {
        _linkRepositoryMock = new Mock<IBaseRepository<Link>>();
        _handler = new CountLinksQueryHandler(_linkRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _linkRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountLinksQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Links : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.LinksCount);

        _linkRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}