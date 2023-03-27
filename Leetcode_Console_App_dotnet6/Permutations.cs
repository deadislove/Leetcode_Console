using System;
using System.Collections.Generic;

namespace Leetcode_Console_App
{
    internal static class Permutations
    {
        public static void Client() {

            int[] inputArr = new int[] { 1, 2, 3 };
            var result = Permute(inputArr);
        }

        // Reference: https://leetcode.com/problems/permutations/solutions/625312/c-knuth-s-algorithm-l-implementation-narayana/
        public static IList<IList<int>> Permute(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>(nums));
            int len = nums.Length;
            while (true)
            {
                List<int> perm = new List<int>(nums);
                int j = len - 2;
                while (j >= 0 && perm[j] >= perm[j + 1])
                    j--;
                if (j < 0)
                    break;
                int l = len - 1;
                while (perm[j] >= perm[l])
                    l--;
                (perm[j], perm[l]) = (perm[l], perm[j]);
                int k = j + 1;
                l = len - 1;
                while (k < l)
                {
                    (perm[k], perm[l]) = (perm[l], perm[k]);
                    k++;
                    l--;
                }
                result.Add(perm);
                nums = perm.ToArray();
            }
            return result;
        }

        // Reference: https://leetcode.com/problems/permutations/solutions/1702063/c-easy-to-understand-the-best-functions-are-those-with-no-parameters-less-parameters/?orderBy=most_votes&page=2&languageTags=csharp
        public static class Solution {
            static IList<IList<int>> numsPerm = new List<IList<int>>();
            static int n = 0;
            static int[] _nums;
            static HashSet<int> _taken;
            public static IList<IList<int>> Permute(int[] nums)
            {
                n = nums.Length;
                _nums = nums;
                _taken = new HashSet<int>();
                PermuteHelper(new List<int> { });
                return numsPerm;

            }

            static void PermuteHelper(List<int> perms)
            {
                if (perms.Count == n)
                {
                    var currPerms = new List<int>();
                    currPerms.AddRange(perms);
                    numsPerm.Add(currPerms);
                    return;
                }

                for (int end = 0; end < n; end++)
                {
                    int num = _nums[end];
                    if (_taken.Contains(num)) continue;
                    _taken.Add(num);
                    perms.Add(num);
                    PermuteHelper(perms);
                    _taken.Remove(num);
                    perms.RemoveAt(perms.Count - 1);
                }
            }
        }
    }
}
