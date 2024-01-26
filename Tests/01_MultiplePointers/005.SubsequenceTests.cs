#nullable enable

using ADS.MultiplePointers;
using NUnit.Framework;

namespace Tests.MultiplePointers;

[TestFixture]
public static class SubsequenceTests
{
    [Test]
    [TestCase("abc", "adbxcq", true)]
    [TestCase("hello", "hello world", true)]
    [TestCase("sing", "sting", true)]
    [TestCase("abc", "acb", false)]
    public static void IsSubsequence_WhenCalled_ReturnExpectedValue(string firstString, string secondString, bool expectedResult)
    {
        var result = SubsequenceProblem.IsSubsequence(firstString, secondString);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
