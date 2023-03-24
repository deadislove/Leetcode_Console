using System;

namespace Leetcode_Console_App
{
    internal static class Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public static void Client()
        {
            int[] inputArr = new int[] { 5, 7, 7, 8, 8, 10 };
            var result = SearchRange(inputArr, 8);
            foreach (var i in result) {
                Console.WriteLine(i);
            }
        }

        // Reference: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/solutions/1970389/c-2-sol/
        public static int[] SearchRange(int[] nums, int target)
        {
            int[] rets = { -1, -1 };
            int i = 0, j = nums.Length - 1;
            bool foundFirst = false, foundLast = false;

            while (i <= j && !(foundFirst && foundLast))
            {
                if (!foundFirst)
                {
                    if (nums[i] == target)
                    {
                        rets[0] = i;
                        foundFirst = true;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (!foundLast)
                {
                    if (nums[j] == target)
                    {
                        rets[1] = j;
                        foundLast = true;
                    }
                    else
                    {
                        j--;
                    }
                }
            }

            return rets;
        }
    }
}
