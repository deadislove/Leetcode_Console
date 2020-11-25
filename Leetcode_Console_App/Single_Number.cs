using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Single_Number
    {
        //Problem link: https://leetcode.com/problems/single-number/

        /* XOR calculation.
         * Same value exports 0.
         * Difference value exports 1.
         */
        public int SingleNumber(int[] nums)
        {
            int value = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                value ^= nums[i];
            }
            return value;
        }
    }
}
