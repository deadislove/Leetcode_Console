using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode_Console_App
{
    internal static class Combination_Sum_II
    {
        public static void Client() { }

        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            List<IList<int>> result = new List<IList<int>>();
            List<int> comb = new List<int>();
            CombinationSum2(candidates, target, 0, 0, comb, result);
            return result;
        }

        private static void CombinationSum2(int[] cand, int target, int sum, int start, List<int> comb, List<IList<int>> result)
        {
            if (sum == target)
                result.Add(comb.ToList());
            else if (sum < target)
                for (int i = start; i < cand.Length; i++)
                {
                    if (i > start && cand[i - 1] == cand[i])
                        continue;
                    comb.Add(cand[i]);
                    CombinationSum2(cand, target, sum + cand[i], i + 1, comb, result);
                    comb.RemoveAt(comb.Count - 1);
                }
        }
    }
}
