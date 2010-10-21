using NUnit.Framework;
using TheClassLibrary;

namespace NUnitTestRunner
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void TestThatSomethingIsReturned()
        {
            var value = "Here's some value to return";

            Assert.AreEqual(value, ClassToTest.ReturnSomething(value));
        }

    }
}
