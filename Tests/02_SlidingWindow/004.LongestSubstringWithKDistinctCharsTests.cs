namespace Tests.SlidingWindow;

using ADS;
using ADS.SlidingWindow;
using NUnit.Framework;

public static class LongestSubstringWithKDistinctCharsTests
{
    [TestFixture]
    public class GetLongestSubstringLengthKTests
    {
        [Test]
        [TestCase("araaci", 2, 4)]
        [TestCase("araaci", 1, 2)]
        [TestCase("cbbebi", 3, 5)]
        [TestCase("eceba", 2, 3)]
        public void GetLongestSubstringKLength_WhenCalled_ReturnExpectedValue(string theString, int differentChars, int expectedResult)
        {
            var result = LongestSubstringWithKDistinctCharsProblem.GetLongestSubstringK(theString, differentChars);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
