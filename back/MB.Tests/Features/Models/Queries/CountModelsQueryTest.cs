using MB.Application.Features.Models.Queries.CountModels;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Models.Queries;

public class CountModelsQueryTest
{
    private readonly Mock<IBaseRepository<Model>> _modelRepositoryMock;
    private readonly CountModelsQueryHandler _handler;

    public CountModelsQueryTest()
    {
        _modelRepositoryMock = new Mock<IBaseRepository<Model>>();
        _handler = new CountModelsQueryHandler(_modelRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _modelRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountModelsQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Models : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.ModelsCount);

        _modelRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}