using MB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MB.Application.Test
{
    public class TagShould
    {
        [Fact]
        public void Test()
        {
            Tag sut = new Tag();

            sut.Name = "New Tag";

            Assert.NotNull(sut);
        }
    }
}
