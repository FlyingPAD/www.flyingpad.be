using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.TaskCategories.Queries.CountTaskCategories;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.TaskCategorys.Queries;

public class CountTaskCategoriesQueryTest
{
    private Mock<IBaseRepository<TaskCategory>> _taskCategoryRepositoryMock;
    private CountTaskCategoriesQueryHandler _handler;

    public CountTaskCategoriesQueryTest()
    {
        _taskCategoryRepositoryMock = new Mock<IBaseRepository<TaskCategory>>();
        _handler = new CountTaskCategoriesQueryHandler(_taskCategoryRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _taskCategoryRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountTaskCategoriesQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Task Categories : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.TaskCategoriesCount);

        _taskCategoryRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}