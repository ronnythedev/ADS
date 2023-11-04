#nullable enable

using ADS.MultiplePointers;
using NUnit.Framework;

namespace Tests.MultiplePointers;

[TestFixture]
public static class PairSumZeroTests
{
    [Test]
    [TestCase(new int[] { -3, -2, -1, 0, 1, 2, 3 }, new int[] { -3, 3 })]
    [TestCase(new int[] { -4, -3, -2, -1, 0, 1, 2, 3, 10 }, new int[] { -3, 3 })]
    [TestCase(new int[] { -2, 0, 1, 3 }, null)]
    [TestCase(new int[] { 1, 2, 3 }, null)]
    public static void SumZero_WhenCalled_ReturnExpectedValue(int[] setOfNumbers, int[]? expectedResult)
    {
        var result = PairSumZeroProblem.SumZero(setOfNumbers);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
