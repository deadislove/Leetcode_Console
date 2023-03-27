using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Summary_Ranges
    {
        /* Problem link: https://leetcode.com/problems/summary-ranges/
         */

        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> list = new List<string>();

            if (nums.Length == 1)
            {
                list.Add(nums[0].ToString());
                return list;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i];
                while (i + 1 < nums.Length && (nums[i + 1] - nums[i]) == 1)
                {
                    i++;
                }

                if (a != nums[i])
                    list.Add(a + "->" + nums[i]);
                else
                    list.Add(a.ToString());
            }

            return list;
        }
    }
}
