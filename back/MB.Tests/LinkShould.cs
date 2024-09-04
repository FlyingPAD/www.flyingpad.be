using MB.Domain.Entities;
using Xunit;

namespace MB.Tests;

[Trait("Category", "Link")]
public class LinkShould
{
    [Fact]
    public void Test()
    {
        // Arrange

        Link sut = new()
        {
            // Act

            Name = "# New Link"
        };

        // Assert

        Assert.NotNull(sut);

    }

    [Fact]
    public void Test2()
    {
        // Arrange

        Link sut = new()
        {
            // Act

            Name = "# New Link"
        };

        // Assert

        Assert.NotNull(sut);

    }
}