#nullable enable

using ADS.MultiplePointers;
using NUnit.Framework;

namespace Tests.MultiplePointers;

[TestFixture]
public static class TwoSumTests
{
    [Test]
    [TestCase(new int[] { 2, 7, 1, 15 }, 9, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public static void TwoSum_WhenCalled_ReturnExpectedValue(int[] setOfNumbers, int target, int[]? expectedResult)
    {
        var result = TwoSumProblem.TwoSum(setOfNumbers, target);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
