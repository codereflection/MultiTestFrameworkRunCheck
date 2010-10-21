using Machine.Specifications;
using TheClassLibrary;

namespace MSpecTestRunner
{
    public class MSpecTests
    {
        private static string value;
        private static string result;

        Establish context = () => 
            value = "The answer is 42.";

        Because of = () =>
            result = ClassToTest.ReturnSomething(value);

        It should_have_a_result = () =>
            result.ShouldEqual(value);
    }
}
