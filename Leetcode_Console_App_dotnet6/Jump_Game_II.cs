using System;

namespace Leetcode_Console_App
{
    internal static class Jump_Game_II
    {
        public static void Client() {
            int[] inputArr = new int[] { 2, 3, 1, 1, 4 };
            var result = Jump(inputArr);
            Console.WriteLine($"Result: {result}");
        }

        // Approach 1: Greedy
        public static int Jump(int[] nums)
        {
            int answer = 0;
            int n = nums.Length;
            int curEnd = 0;
            int curFar = 0;

            for (int i = 0; i < n - 1; i++)
            {
                curFar = Math.Max(curFar, i + nums[i]);

                if (i == curEnd)
                {
                    answer++;
                    curEnd = curFar;
                }
            }

            return answer;
        }
    }
}
