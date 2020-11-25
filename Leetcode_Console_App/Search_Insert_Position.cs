using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Search_Insert_Position
    {
        //Problem link: https://leetcode.com/problems/search-insert-position/

        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int i = 0, j = nums.Length - 1;
            int index = -1;

            while (i <= j)
            {
                index = (i + j) / 2;
                if (nums[index] == target)
                    return index;
                if (nums[index] >= target)
                    j = index - 1;
                else
                    i = index + 1;
            }

            return i;
        }
    }
}
