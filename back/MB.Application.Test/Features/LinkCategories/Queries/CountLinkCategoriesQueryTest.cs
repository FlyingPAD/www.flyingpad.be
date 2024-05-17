using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.LinkCategories.Queries.CountLinkCategories;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.LinkCategories.Queries;

public class CountLinkCategoriesQueryTest
{
    private Mock<IBaseRepository<LinkCategory>> _linkCategoryRepositoryMock;
    private CountLinkCategoriesQueryHandler _handler;


    public CountLinkCategoriesQueryTest()
    {
        _linkCategoryRepositoryMock = new Mock<IBaseRepository<LinkCategory>>();
        _handler = new CountLinkCategoriesQueryHandler(_linkCategoryRepositoryMock.Object);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
    {
        // Arrange

        var expectedCount = 42;

        _linkCategoryRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

        var request = new CountLinkCategoriesQuery();

        // Act

        var result = await _handler.Handle(request, new CancellationToken());

        // Assert

        Assert.True(result.Success);
        Assert.Equal($"Total Link Categories : {expectedCount}", result.Message);
        Assert.Equal(expectedCount, result.LinkCategoriesCount);

        _linkCategoryRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
    }
}