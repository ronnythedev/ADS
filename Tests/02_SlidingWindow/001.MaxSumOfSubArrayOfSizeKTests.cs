using ADS.SlidingWindow;
using NUnit.Framework;

namespace Tests.SlidingWindow
{
    public static class MaxSumOfSubArrayOfSizeKSetTests
    {
        [TestFixture]
        public class MaxSumOfSubArrayOfSizeKTests
        {
            [Test]
            [TestCase(3, new[] { 2, 1, 5, 1, 3, 2 }, 9)]
            [TestCase(2, new[] { 2, 3, 4, 1, 5 }, 7)]
            public void MaxSumSubArray_WhenCalled_ReturnTheMaxSumOfSubArrayOfSizeK(int k, int[] arr, int expectedResult)
            {
                var result = MaxSumOfSubArrayOfSizeK.MaxSumOfSubArrayOfSizeKSolution(k, arr);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
    }
}