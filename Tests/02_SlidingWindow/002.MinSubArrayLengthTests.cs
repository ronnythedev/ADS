namespace Tests.SlidingWindow;

using ADS.SlidingWindow;
using NUnit.Framework;

public static class MinSubArrayLengthTests
{
    [TestFixture]
    public class GetMinSubarrayLengthTests
    {
        [Test]
        [TestCase(new int[] { 2, 3, 1, 2, 4, 3 }, 7, 2)]
        [TestCase(new int[] { 2, 1, 6, 5, 4 }, 9, 2)]
        [TestCase(new int[] { 3, 1, 7, 11, 2, 9, 8, 21, 62, 33, 19 }, 52, 1)]
        [TestCase(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 39, 3)]
        [TestCase(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 55, 5)]
        [TestCase(new int[] { 4, 3, 3, 8, 1, 2, 3 }, 11, 2)]
        [TestCase(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 95, 0)]
        public void GetMinSubarrayLength_WhenCalled_ReturnExpectedValue(int[] listOfNumbers, int k, int expectedResult)
        {
            var result = MinSubArrayLengthProblem.GetMinSubarrayLength(listOfNumbers, k);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
