using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Two_Sum
    {
        //Problem link: https://leetcode.com/problems/two-sum/

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = null;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                        result = new int[] { i, j };
                }
            }

            return result;
        }
    }
}
