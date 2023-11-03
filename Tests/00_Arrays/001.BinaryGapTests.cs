using ADS.Arrays;
using NUnit.Framework;

namespace Tests.Arrays
{
    [TestFixture]
    public class BinaryGapTests
    {
        [Test]
        [TestCase(9, 2)]
        [TestCase(529, 4)]
        [TestCase(20, 1)]
        [TestCase(15, 0)]
        [TestCase(32, 0)]
        [TestCase(1041, 5)]
        public void BinaryGap_WhenCalled_ReturnTheGreaterBinaryGap(int a, int expectedResult)
        {
            var result = BinaryGapProblem.BinaryGap(a);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}