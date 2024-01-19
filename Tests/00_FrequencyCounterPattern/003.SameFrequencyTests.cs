using ADS.FrequencyCounterPattern;
using NUnit.Framework;

namespace Tests.FrequencyCounterPattern;

[TestFixture]
public class SameFrequencyTests
{
    [Test]
    [TestCase(182, 281, true)]
    [TestCase(34, 14, false)]
    [TestCase(3589578, 5879385, true)]
    [TestCase(22, 222, false)]
    public void SameFrequency_WhenCalled_ReturnExpectedValue(int firstNumber, int secondNumber, bool expectedResult)
    {
        var result = SameFrequencyProblem.HaveSameFrequency(firstNumber, secondNumber);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}

