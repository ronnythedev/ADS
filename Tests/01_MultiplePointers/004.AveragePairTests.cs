#nullable enable

using ADS.MultiplePointers;
using NUnit.Framework;

namespace Tests.MultiplePointers;

[TestFixture]
public static class AveragePairTests
{
    [Test]
    [TestCase(new int[] { 1, 2, 3 }, 2.5, true)]
    [TestCase(new int[] { 1, 3, 3, 5, 6, 7, 10, 12, 19 }, 8, true)]
    [TestCase(new int[] { -1, 0, 3, 4, 5, 6 }, 4.1, false)]
    [TestCase(new int[] { }, 4, false)]
    public static void AveragePair_WhenCalled_ReturnExpectedValue(int[] setOfNumbers, decimal target, bool expectedResult)
    {
        var result = AveragePairProblem.AveragePair(setOfNumbers, target);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
