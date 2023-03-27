using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Majority_Element
    {
        //Problem link: https://leetcode.com/problems/majority-element/
        //Brute Force
        /* Time Limit Exceeded
         */
        public int MajorityElement(int[] nums)
        {
            int Count = nums.Length / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        temp += 1;
                }

                if (temp > Count)
                    return nums[i];
            }

            return -1;
        }

        /// <summary>
        /// Leetcode - Approach 2: HashMap
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement2(int[] nums)
        {
            Dictionary<int, int> counts = countNums(nums);
            int max = counts.Values.Max();
            int key = counts.FirstOrDefault(x => x.Value == max).Key;

            return key;
        }

        private Dictionary<int, int> countNums(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!counts.ContainsKey(nums[i]))
                    counts.Add(nums[i], 1);
                else
                    counts[nums[i]] += 1; 
            }

            return counts;
        }

       
    }
}
