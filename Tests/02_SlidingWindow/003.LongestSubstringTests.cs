namespace Tests.SlidingWindow;

using ADS.SlidingWindow;
using NUnit.Framework;

public static class LongestSubstringTests
{
    [TestFixture]
    public class GetLongestSubstringLengthTests
    {
        [Test]
        [TestCase("", 0)]
        [TestCase("rithmschool", 7)]
        [TestCase("thisisawesome", 6)]
        [TestCase("thecatinthehat", 7)]
        [TestCase("bbbbbb", 1)]
        [TestCase("longestsubstring", 8)]
        [TestCase("thisishowwedoit", 6)]

        public void GetLongestSubstringLength_WhenCalled_ReturnExpectedValue(string theString, int expectedResult)
        {
            var result = LongestSubstringProblem.GetLongestSubstring(theString);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
