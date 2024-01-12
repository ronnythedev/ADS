namespace Tests.SlidingWindow;

using ADS.SlidingWindow;
using NUnit.Framework;

public static class MaxSumOfSubArrayOfSizeKSetTests
{
    [TestFixture]
    public class MaxSumOfSubArrayOfSizeKTests
    {
        [Test]
        [TestCase(3, new int[] { 2, 1, 5, 1, 3, 2 }, 9)]
        [TestCase(2, new int[] { 2, 3, 4, 1, 5 }, 7)]
        [TestCase(2, new int[] { 1, 2, 5, 2, 8, 1, 5 }, 10)]
        [TestCase(4, new int[] { 1, 2, 5, 2, 8, 1, 5 }, 17)]
        [TestCase(1, new int[] { 4, 2, 1, 6 }, 6)]
        [TestCase(4, new int[] { 4, 2, 1, 6, 2 }, 13)]
        [TestCase(4, new int[] { }, null)]
        [TestCase(7, new int[] { 1, 2, 3 }, null)]
        public void MaxSumSubArray_WhenCalled_ReturnTheMaxSumOfSubArrayOfSizeK(int k, int[] arr, int? expectedResult)
        {
            var result = MaxSumOfSubArrayOfSizeKProblem.MaxSumOfSubArrayOfSizeKSolution(k, arr);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
