using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Remove_Element
    {
        //Problem link: https://leetcode.com/problems/remove-element/

        public int RemoveElement(int[] nums, int val)
        {
            if (null == nums || nums.Length == 0) return 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count++] = nums[i];
                }
            }
            return count;
        }
    }
}
