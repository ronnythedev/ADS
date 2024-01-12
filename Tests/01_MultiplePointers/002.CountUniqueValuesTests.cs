#nullable enable

using ADS.MultiplePointers;
using NUnit.Framework;

namespace Tests.MultiplePointers;

[TestFixture]
public static class CountUniqueVAluesTests
{
    [Test]
    [TestCase(new int[] { 1, 1, 1, 1, 1, 2 }, 2)]
    [TestCase(new int[] { 1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13 }, 7)]
    [TestCase(new int[] { }, 0)]
    [TestCase(new int[] { -2, -1, -1, 0, 1 }, 4)]
    public static void CountUniqueValues_WhenCalled_ReturnExpectedValue(int[] setOfNumbers, int[]? expectedResult)
    {
        var result = CountUniqueValuesProblem.UniqueValues(setOfNumbers);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
