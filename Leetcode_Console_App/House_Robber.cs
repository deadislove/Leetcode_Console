using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class House_Robber
    {
        //Problem link: https://leetcode.com/problems/house-robber/

        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];

            int[] count = new int[nums.Length];
            count[0] = nums[0];
            count[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                count[i] = Math.Max(count[i - 2] + nums[i], count[i - 1]);
            }

            return count[nums.Length - 1];
        }
    }
}
