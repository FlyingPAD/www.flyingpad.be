using MB.Domain.Entities;
using Xunit;

namespace MB.Tests;

public class ArtistShould
{
    [Fact]
    [Trait("Category", "Artist")]
    public void Test()
    {
        // Arrange

        Artist sut = new()
        {
            // Act

            Name = "# New Artist"
        };

        // Assert

        Assert.NotNull(sut);

    }
}