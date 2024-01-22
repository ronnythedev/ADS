using ADS.FrequencyCounterPattern;
using NUnit.Framework;

namespace Tests.FrequencyCounterPattern;

[TestFixture]
public class DuplicatesInArrayTests
{
    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8 }, true)]
    [TestCase(new int[] { 1, 2, 3 }, false)]
    [TestCase(new int[] { 1, 2, 2 }, true)]
    [TestCase(new int[] { 3, 6, 7, 0, 34, 6, 12, 8, 56, 9, 3 }, true)]
    public void DuplicatesInArray_WhenCalled_ReturnExpectedValue(int[] listOfNumbers, bool expectedResult)
    {
        var result = DuplicatesInArrayProblem.ThereAreDuplicates(listOfNumbers);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}

