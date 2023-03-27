using System;

namespace Leetcode_Console_App
{
    internal static class Jump_Game
    {
        public static void Client() {
            int[] inputArr = new int[] { 2, 3, 1, 1, 4 };
            var result = CanJump(inputArr);
            Console.WriteLine($"Result: {result}");
            inputArr = new int[] { 3, 2, 1, 0, 4 };
            result = CanJump(inputArr);
            Console.WriteLine($"Result: {result}");
        }

        public static bool CanJump(int[] nums)
        {
            // The end of the array is true, since that means we are at the solution.
            int nearestTrue = nums.Length - 1;

            // Working backwards through the array we want to check if our current num can jump us to the nearest 'TRUE'.
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                // If we can jump to the nearest true, we become the nearest true.
                if (i + nums[i] >= nearestTrue)
                {
                    nearestTrue = i;
                }
            }

            // If the nearest true is the start, the entire solution is jumpable.
            return nearestTrue == 0;
        }
    }
}
