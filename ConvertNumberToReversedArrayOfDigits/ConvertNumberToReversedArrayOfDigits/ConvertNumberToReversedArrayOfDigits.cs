using System;
using System.Diagnostics;

namespace CodeKata
{
    public class ConvertNumberToReversedArrayOfDigits
    {
        static void Main(string[] args)
        {
            Digitize(123);
        }

        public static long[] Digitize(long n)
        {
            string nString = n.ToString();
            long[] returnLong = new long[nString.Length];
            int counter = nString.Length-1;
            foreach(char num in nString)
            {
                returnLong[counter] = Convert.ToInt64(Char.GetNumericValue(num));
                Debug.WriteLine(returnLong[counter]);
                counter--;
            }
            return returnLong;
        }
    }
}
