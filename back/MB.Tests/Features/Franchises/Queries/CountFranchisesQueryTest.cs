using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Franchises.Queries.CountFranchises;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Franchises.Queries;

public class CountFranchisesQueryTest
{
    private Mock<IBaseRepository<Franchise>> _franchiseRepositoryMock;
    private CountFranchisesQueryHandler _handler;


    public CountFranchisesQueryTest()
    {
        _franchiseRepositoryMock = new Mock<IBaseRepository<Franchise>>();
        _handler = new CountFranchisesQueryHandler(_franchiseRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _franchiseRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountFranchisesQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Franchises : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.FranchisesCount);

        _franchiseRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);

    }
}