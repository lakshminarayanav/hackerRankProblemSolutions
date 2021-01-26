using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankSolutions
{
    public class Palindrom
    {

        public static bool isScatteredPalindrom(string s)
        {
            var distinctChars = s.Distinct();
            List<char> inputStr = s.ToCharArray().ToList();
            int distinctCharOccurences = 0;
            foreach (Char c in distinctChars)
            {
                if ((inputStr.FindAll(ch => ch == c).Count % 2 == 1))
                {
                    distinctCharOccurences++;
                }
            }


            return distinctCharOccurences > 1 ? false : true;

        }

        public static int getScatteredPalindromCount(string s)
        {
            int count = 0;
            string substr = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; i + j <= s.Length; j++)
                {
                    substr = s.Substring(i, j);
                    if (isScatteredPalindrom(substr))
                    {
                        count++;
                        Console.WriteLine(substr);
                    }
                }

            }

            Console.WriteLine($"total possible palindroms is : {count}");
            return count;
        }

        public static List<int> ListOfScatteredPalindroms(List<string> input)
        {
            List<int> result = new List<int>();
            foreach (string s in input)
            {
                result.Add(getScatteredPalindromCount(s));
            }
            return result;

        }
    }
}
