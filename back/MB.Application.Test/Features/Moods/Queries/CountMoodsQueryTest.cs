using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Moods.Queries.CountMoods;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Moods.Queries;

public class CountMoodsQueryTest
{
    private Mock<IBaseRepository<Mood>> _moodRepositoryMock;
    private CountMoodsQueryHandler _handler;

    public CountMoodsQueryTest()
    {
        _moodRepositoryMock = new Mock<IBaseRepository<Mood>>();
        _handler = new CountMoodsQueryHandler(_moodRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _moodRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountMoodsQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Moods : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.MoodsCount);

        _moodRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}