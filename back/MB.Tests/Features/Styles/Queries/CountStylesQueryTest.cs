using MB.Application.Features.Styles.Queries.CountStyles;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Styles.Queries;

public class CountStylesQueryTest
{
    private Mock<IBaseRepository<Style>> _styleRepositoryMock;
    private CountStylesQueryHandler _handler;

    public CountStylesQueryTest()
    {
        _styleRepositoryMock = new Mock<IBaseRepository<Style>>();
        _handler = new CountStylesQueryHandler(_styleRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _styleRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountStylesQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Styles : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.StylesCount);

        _styleRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}