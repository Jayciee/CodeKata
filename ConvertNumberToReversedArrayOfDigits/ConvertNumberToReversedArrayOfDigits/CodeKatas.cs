using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CodeKata
{
    public class CodeKatas
    {
        static void Main(string[] args)
        {
            Digitize(123);
            string input = "abc123def";
            var output = Regex.Replace(input, @"\d", m => (m.Value[0] - '0' + 5).ToString());
            Console.WriteLine(output);
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
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            ////MultipleLines
            //if (humanYears == 1) 
            //{ 
            //    return new int[] { 1,15,15}; 
            //}
            //else if( humanYears == 2)
            //{
            //    return new int[] { 2, 24, 24 };
            //}
            //else
            //{
            //    return new int[] { humanYears, 24+ (humanYears - 2) * 4, 24 + (humanYears - 2) * 5 };
            //}
            //OneLine
            return humanYears >= 3 ? new int[] { humanYears, 24 + (humanYears - 2) * 4, 24 + (humanYears - 2) * 5 } : humanYears == 2 ? new int[] { 2, 24, 24 } : new int[] { 1, 15, 15 };
        }

        public static string Switcheroo(string x)
        {
            ////Multiple Line
            //List<char> returnList = new List<char>();
            //foreach(char letter in x.ToLower())
            //{
            //    if (letter == 'a')
            //    {
            //        returnList.Add('b');
            //    }
            //    else if (letter == 'b')
            //    {
            //        returnList.Add('a');
            //    }
            //    else returnList.Add(letter);
            //}
            //return new String(returnList.ToArray());
            //One Line
            return x.Replace("a", "999").Replace("b", "a").Replace("999", "b");
        }
    }
}
