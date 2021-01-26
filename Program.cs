using System;
using System.Collections.Generic;
using HackerRankSolutions;

namespace Samples
{
    class Program
    {

        static void Main(string[] args)
        {



            #region Problem #1 - get Countries by given minimum Population
            int minPopulation = 300;
            int result = HRWebRequest.getCountries("un", minPopulation);
            Console.WriteLine($"number of countries having population more than {minPopulation} is : {result}");
            #endregion

            
            
            
            #region Problem #2 - print number of possible scattered palindrom sub strings for each string in given list of strings.

            List<string> inputStrings = new List<string> { "bbrrg", "abc", "onino", "brrbrg" };
            var listCount = Palindrom.ListOfScatteredPalindroms(inputStrings);
            foreach (int c in listCount)
            {
                Console.WriteLine("Count is" + c);
            }
            #endregion

            #region problem #3 - print maximum of minimum value in sub sets of size x in given set of n elements, where 1 <= x <= n 

            int[] inputset = { 1, 2, 2, 3, 4, 6 };

            int space = 1;
            int maxValue = SubSets.findMaximumOfMinimumInSubSets(space, inputset);
            Console.WriteLine($"Maximum of Minimum values of each subset is {maxValue}");

            #endregion

        }
    }


}
