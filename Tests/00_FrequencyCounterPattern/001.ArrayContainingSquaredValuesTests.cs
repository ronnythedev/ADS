using ADS.FrequencyCounterPattern;
using NUnit.Framework;

namespace Tests.FrequencyCounterPattern
{
    [TestFixture]
    public class ArrayContainingSquaredValuesTests
    {
        [Test]
        [TestCase(new int[] { 2, 3, 4 }, new int[] { 4, 9, 16 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4, 9 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4, 9, 10 })]
        public void ArrayContainingSquaredValues_WhenCalled_ReturnTrueIfSecondArrayHaveAllSquaredValues(int[] firstArray, int[] secondArray)
        {
            var result = ArrayContainingSquaredValuesProblem.SecondArrayHaveAllSquaredValues(firstArray, secondArray);

            Assert.That(result, Is.True);
        }
    }
}
