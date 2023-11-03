using ADS.FrequencyCounterPattern;
using NUnit.Framework;

namespace Tests.FrequencyCounterPattern;

[TestFixture]
public class ArrayContainingSquaredValuesTests
{
    [Test]
    [TestCase(new int[] { 2, 3, 4 }, new int[] { 4, 9, 16 }, true)]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 1, 9 }, true)]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4 }, false)]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4, 5 }, false)]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4, 9, 10 }, false)]
    [TestCase(new int[] { 1, 2, 1 }, new int[] { 4, 4, 1 }, false)]
    [TestCase(new int[] { 2, 3, 6, 8, 8 }, new int[] { 64, 36, 4, 9, 64 }, true)]
    public void ArrayContainingSquaredValues_WhenCalled_ReturnExpectedValue(int[] firstArray, int[] secondArray, bool expectedResult)
    {
        var result = ArrayContainingSquaredValuesProblem.SameSquared(firstArray, secondArray);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}

