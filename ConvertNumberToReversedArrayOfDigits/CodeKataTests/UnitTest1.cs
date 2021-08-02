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
            Assert.AreEqual(expected, ConvertNumberToReversedArrayOfDigits.Digitize(testNum));
        }
        
    }
}