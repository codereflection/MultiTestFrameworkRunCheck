using TheClassLibrary;
using Xunit;

namespace XUnitTests
{
    public class XUnitTests
    {
        [Fact]
        public void TestThatSomethingIsReturned()
        {
            var value = "Here's some value to return";

            Assert.Equal(value, ClassToTest.ReturnSomething(value));
        }

    }
}
