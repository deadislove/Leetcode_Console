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

        /// <summary>
        /// Leetcode solution - Approach 1: Two Pointers   
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        /*
         * Intuition
         * Since this question is asking us to remove all elements of the given value in-place, we have to handle it with O(1) extra space. 
         * How to solve it? We can keep two pointers i and j, where i is the slow-runner while j is the fast-runner.
         * 
         * Algorithm
         * When nums[j]nums[j] equals to the given value, skip this element by incrementing j. 
         * As long as nums[j] \neq val, we copy nums[j] to nums[i] and increment both indexes at the same time. Repeat the process until j reaches the end of the array and the new length is i.
         * 
         */
        public int RemoveElement2(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }


        /// <summary>
        /// Leetcode - Approach 2: Two Pointers - when elements to remove are rare
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement3(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    // reduce array size by one
                    n--;
                }
                else
                    i++;
            }

            return n;
        }
    }
}
