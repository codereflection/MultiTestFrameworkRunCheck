using MbUnit.Framework;
using TheClassLibrary;

namespace GallioTests
{
    [TestFixture]
    public class GallioTests
    {
        [Test]
        public void TestThatSomethingIsReturned()
        {
            var value = "Here's some value to return";

            Assert.AreEqual(value, ClassToTest.ReturnSomething(value));
        }
    }
}
