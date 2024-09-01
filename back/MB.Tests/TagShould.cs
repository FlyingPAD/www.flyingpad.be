using MB.Domain.Entities;
using Xunit;

namespace MB.Application.Test;

public class TagShould
{
    [Fact]
    public void Test()
    {
        Tag sut = new()
        {
            Name = "New Tag"
        };

        Assert.NotNull(sut);
    }
}
