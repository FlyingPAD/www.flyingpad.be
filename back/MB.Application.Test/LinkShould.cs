using MB.Domain.Entities;
using Xunit;

namespace MB.Application.Test;

[Trait("Category", "Link")]
public class LinkShould
{
    [Fact]
    public void Test()
    {
        // Arrange

        Link sut = new Link();

        // Act

        sut.Name = "# New Link";

        // Assert

        Assert.NotNull(sut);

    }

    [Fact]
    public void Test2()
    {
        // Arrange

        Link sut = new Link();

        // Act

        sut.Name = "# New Link";

        // Assert

        Assert.NotNull(sut);

    }
}