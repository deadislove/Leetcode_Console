using System;

namespace Leetcode_Console_App
{
    public static class Container_With_Most_Water
    {
        public static void Client() { }

        /* Brute Force
         * Result: Time Limit Exceeded
         */
        public static int MaxArea(int[] height)
        {
            int maxarea = 0;
            for (int left = 0; left < height.Length; left++)
            {
                for (int right = left + 1; right < height.Length; right++)
                {
                    int width = right = left;
                    maxarea = Math.Max(maxarea, Math.Min(height[left], height[right]) * width);
                }
            }
            return maxarea;
        }


        /* Two Pointer Approach
         */
        public static int MaxArea2(int[] height)
        {
            int maxarea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right) {
                int width = right - left;
                maxarea = Math.Max(maxarea, Math.Min(height[left], height[right]) * width);
                if (height[left] <= height[right]) left++;
                else right--;
            }
            return maxarea;
        }
    }
}
