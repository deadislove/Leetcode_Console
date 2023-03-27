using System;

namespace Leetcode_Console_App
{
    internal static class First_Missing_Positive
    {
        public static void Client() { }

        // Reference: https://leetcode.com/problems/first-missing-positive/solutions/2897452/c-first-missing-positive-solution/
        public static int FirstMissingPositive(int[] nums)
        {
            // Move all the non-positive numbers to the left of the array.
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    j++;
                }
            }

            // Mark the numbers that are present in the array as negative.
            // The array can contain numbers in the range 1 to n, so we need
            // to use the absolute value of the numbers to index the array.
            for (int i = j; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]);
                if (index > 0 && index <= nums.Length - j)
                {
                    nums[j + index - 1] = -Math.Abs(nums[j + index - 1]);
                }
            }

            // Find the first positive number in the array.
            for (int i = j; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    return i - j + 1;
                }
            }

            // If all numbers are negative, the smallest missing positive
            // number is the length of the array plus one.
            return nums.Length - j + 1;
        }
    }
}
