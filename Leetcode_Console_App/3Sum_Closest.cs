using System;
using System.Collections.Generic;

namespace Leetcode_Console_App
{
    public static class _3Sum_Closest
    {
        public static void Client() {
            List<Tuple<int[], int>> inputArr = new List<Tuple<int[], int>>();
            inputArr.Add(Tuple.Create(new int[] { -1, 2, 1, -4 }, 1));
            inputArr.Add(Tuple.Create(new int[] { 0, 0, 0 }, 1));
            foreach (var item in inputArr)
            {
                var result = ThreeSumClosest(item.Item1, item.Item2);
                Console.WriteLine(result);
            }
        }

        // simple O(n^2) solution with two pointers
        // Reference link: https://leetcode.com/problems/3sum-closest/solutions/730761/c-simple-o-n-2-solution-with-two-pointers/?orderBy=most_votes&languageTags=csharp
        public static int ThreeSumClosest(int[] nums, int target)
        {
            int len = nums.Length;
            int diff = int.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < len - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (Math.Abs(sum - target) < Math.Abs(diff))
                        diff = sum - target;
                    if (sum < target)
                        j++;
                    else
                        k--;
                }
                if (diff == 0)
                    break;
            }
            return target + diff;
        }
    }
}
