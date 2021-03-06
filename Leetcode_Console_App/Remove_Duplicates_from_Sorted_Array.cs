﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Remove_Duplicates_from_Sorted_Array
    {
        //Problem link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/

        public int RemoveDuplicates(int[] nums)
        {
            int n = nums.Length;

            if (n == 0 || n == 1)
                return n;

            int[] temp = new int[n];
            int j = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                    temp[j++] = nums[i];
            }

            temp[j++] = nums[n - 1];

            for (int i = 0; i < j; i++)
                nums[i] = temp[i];

            return j;
        }

        /// <summary>
        /// Leetcode solution
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}
