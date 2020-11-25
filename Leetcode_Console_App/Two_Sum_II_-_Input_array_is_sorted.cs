using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Two_Sum_II___Input_array_is_sorted
    {
        //Problem link: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return null;
            int i = 0;
            int j = numbers.Length - 1;

            while (i < j)
            {
                int sum = numbers[i] + numbers[j];

                if (sum < target)
                    i++;
                else if (sum > target)
                    j--;
                else
                    return new int[] { i + 1, j + 1 };
            }

            return null;
        }
    }
}
