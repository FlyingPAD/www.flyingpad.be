using MB.Application.Features.Tasks.Queries.CountTasks;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Tasks.Queries;

public class CountTasksQueryTest
{
    private Mock<IBaseRepository<Domain.Entities.Task>> _taskRepositoryMock;
    private CountTasksQueryHandler _handler;

    public CountTasksQueryTest()
    {
        _taskRepositoryMock = new Mock<IBaseRepository<Domain.Entities.Task>>();
        _handler = new CountTasksQueryHandler(_taskRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _taskRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountTasksQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Tasks : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.TasksCount);

        _taskRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}