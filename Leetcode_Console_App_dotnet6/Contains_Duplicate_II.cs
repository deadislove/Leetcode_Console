using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Contains_Duplicate_II
    {
        /* Problem link: https://leetcode.com/problems/contains-duplicate-ii/
         */

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > k)
                    set.Remove(nums[i - k - 1]);
                if (!set.Add(nums[i]))
                    return true;
            }
            return false;
        }
    }
}
