using System;

namespace Leetcode_Console_App
{
    internal static class Trapping_Rain_Water
    {
        public static void Client() { }

        public static int Trap(int[] height)
        {
            var leftarray = new int[height.Length];
            var rightarray = new int[height.Length];

            int left = 0;
            int right = height.Length - 1;
            int maxleft = 0;
            int maxright = 0;
            int water = 0;

            while (right >= 0)
            {
                maxleft = Math.Max(maxleft, height[left]);
                maxright = Math.Max(maxright, height[right]);
                leftarray[left] = maxleft;
                rightarray[right] = maxright;

                left++;
                right--;
            }

            for (int i = 1; i < height.Length - 1; i++)
            {
                var min = Math.Min(leftarray[i], rightarray[i]);
                if (min >= height[i])
                {
                    water += min - height[i];
                }
            }

            return water;
        }

        // Using 2 pointers
        public static int Trap2(int[] height) {
            int left = 0, right = height.Length - 1;
            int ans = 0;
            int left_max = 0, right_max = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {                     
                    if (height[left] >= left_max)
                        left_max = height[left];
                    else
                        ans += (left_max - height[left]);
                    ++left;
                }
                else
                {
                    if (height[right] >= right_max)
                        right_max = height[right];
                    else
                        ans += (right_max - height[right]);
                    --right;
                }
            }
            return ans;
        }
    }
}
