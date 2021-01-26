using System.Collections.Generic;
using System.Linq;

namespace HackerRankSolutions
{
    public class SubSets
    {
        public static int findMaximumOfMinimumInSubSets(int space, int[] inputArray)
        {
            List<int> minimumOfEachSet = new List<int>();
            int inputArrayLength = inputArray.Length;
            int[][] subsets = new int[inputArrayLength - (space - 1)][];
            for (int i = 0; i + space <= inputArray.Length; i++)
            {
                subsets[i] = new int[space];
                for (int j = 0; j < space; j++)
                {
                    subsets[i][j] = inputArray[i + j];
                }
                minimumOfEachSet.Add(subsets[i].Min());
            }
            int maxOFMins = minimumOfEachSet.Max();
            return minimumOfEachSet.Max();
        }
    }
}
