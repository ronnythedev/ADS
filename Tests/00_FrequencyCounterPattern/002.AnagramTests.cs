using ADS.FrequencyCounterPattern;
using NUnit.Framework;

namespace Tests.FrequencyCounterPattern;

[TestFixture]
public class AnagramTests
{
    [Test]
    [TestCase("", "", true)]
    [TestCase("aaz", "zza", false)]
    [TestCase("anagram", "nagaram", true)]
    [TestCase("rat", "car", false)]
    [TestCase("awesome", "awesom", false)]
    [TestCase("qwerty", "qeywrt", true)]
    [TestCase("texttwisttime", "timetwisttext", true)]
    public void IsValidAnagram_WhenCalled_ReturnExpectedValue(string firstWord, string secondWord, bool expectedResult)
    {
        var result = AnagramProblem.IsValidAnagram(firstWord, secondWord);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}

