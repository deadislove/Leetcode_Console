using System;
using System.Collections.Generic;

namespace Leetcode_Console_App
{
    public static class _4Sum
    {
        public static void Client() { }

        // Reference link: https://leetcode.com/problems/4sum/solutions/1904184/c-solution/
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            List<IList<int>> data = new List<IList<int>>();
            int len = nums.Length - 1;

            //for first value
            for (int i = 0; i < len - 2; i++)
            {

                //first value can't repeat
                if (i == 0 || nums[i] != nums[i - 1])
                {

                    //same as 3-Sum solution
                    //second value
                    for (int j = i + 1; j < len - 1; j++)
                    {

                        //second value also can't repeat
                        if (nums[j] != nums[j - 1] || j == i + 1)
                        {

                            //left and right position
                            int left = j + 1, right = len;
                            while (left < right)
                            {
                                int sum = nums[i] + nums[j] + nums[left] + nums[right];

                                //check sum equals to target and 3rd value also can't repeat
                                if (sum == target && (nums[left] != nums[left - 1] || left == j + 1))
                                {
                                    data.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                                    left++;
                                    right--;
                                }
                                else if (sum > target)
                                {
                                    right--;
                                }
                                else
                                {
                                    left++;
                                }
                            }
                        }
                    }
                }
            }
            return data;
        }
    }
}
