using NUnit.Framework;
using CodeKata;
namespace CodeKataTests
{
    public class Tests
    {
        [TestCase(35231, new long[] {1,3,2,5,3})]
        [TestCase(int.MaxValue, new long[] {7,4,6,3,8,4,7,4,1,2}) ]
        [TestCase(long.MaxValue, new long[] { 7,0,8,5,7,7,4,5,8,6,3,0,2,7,3,3,2,2,9})]
        public void ConvertNumberToReversedArrayOfDigitsTest(long testNum, long[] expected)
        {
            Assert.AreEqual(expected, CodeKatas.Digitize(testNum));
        }
        [Test]
        public void One()
        {
            Assert.AreEqual(new int[] { 1, 15, 15 }, CodeKatas.humanYearsCatYearsDogYears(1));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual(new int[] { 2, 24, 24 }, CodeKatas.humanYearsCatYearsDogYears(2));
        }

        [Test]
        public void Ten()
        {
            Assert.AreEqual(new int[] { 10, 56, 64 }, CodeKatas.humanYearsCatYearsDogYears(10));
        }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("bac", CodeKatas.Switcheroo("abc"));
            Assert.AreEqual("bbbacccabbb", CodeKatas.Switcheroo("aaabcccbaaa"));
            Assert.AreEqual("ccccc", CodeKatas.Switcheroo("ccccc"));
        }
    }
}