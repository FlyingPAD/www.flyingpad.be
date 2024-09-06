using MB.Domain.Entities;
using Xunit;

namespace MB.Tests;

[Trait("Category", "Link")]
public class LinkShould
{
    [Fact]
    public void Test()
    {
        // Arrange.

        // Act.
        Link sut = new()
        {
            Name = "# New Link"
        };

        // Assert.
        Assert.NotNull(sut);

    }

    [Fact]
    public void Test2()
    {
        // Arrange.

        // Act.
        Link sut = new()
        {
            Name = "# New Link"
        };

        // Assert.
        Assert.NotNull(sut);
    }
}