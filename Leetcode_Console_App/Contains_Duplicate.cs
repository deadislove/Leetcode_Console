using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Contains_Duplicate
    {
        /* Problem link: https://leetcode.com/problems/contains-duplicate/
         */

        public bool ContainsDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        return true;
                }
            }

            return false;
        }
    }
}
