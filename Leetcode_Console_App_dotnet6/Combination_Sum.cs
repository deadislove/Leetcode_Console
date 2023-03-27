using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    internal static class Combination_Sum
    {
        public static void Client() { }

        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> comb = new List<int>();
            CombinationSum(candidates, target, 0, 0, comb, result);
            return result;
        }

        private static void CombinationSum(int[] cand, int target, int sum, int i, List<int> comb, List<IList<int>> result)
        {
            if (sum > target)
                return;
            if (sum == target)
            {
                result.Add(comb.ToList());
                return;
            }
            while (i < cand.Length)
            {
                sum += cand[i];
                comb.Add(cand[i]);
                CombinationSum(cand, target, sum, i, comb, result);
                sum -= cand[i];
                comb.RemoveAt(comb.Count - 1);
                i++;
            }
        }
    }
}
