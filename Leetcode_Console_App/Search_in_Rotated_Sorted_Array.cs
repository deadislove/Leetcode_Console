using System;

namespace Leetcode_Console_App
{
    internal static class Search_in_Rotated_Sorted_Array
    {
        public static void Client()
        {
            int[] inputArr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var result = Search(inputArr, 0);
            Console.WriteLine(result);
        }

        // https://leetcode.com/problems/search-in-rotated-sorted-array/solutions/2909017/o-log-n-time-complexity-with-detail-explanation/
        public static int Search(int[] nums, int target)
        {
            // Time Complexity O(log(n)) for function FindPivot
            // Time Complexity for Binary Search below is O(log(n)) in worst case - not rotated
            // The total Time Complexity is 2 * O(log(n)), technically O(log(n))
            int pivot = FindPivot(nums);

            int index = 0;

            if (pivot == -1)
            {
                // If the input nums is not rotated, then search the target number with Binary Search
                index = Array.BinarySearch(nums, 0, nums.Length, target);
            }
            else
            {
                // If the target number is greater than the last element in the rotated array, 
                // then binary search the first half
                // Otherwise, binary search the second half
                if (target > nums[nums.Length - 1])
                {
                    index = Array.BinarySearch(nums, 0, pivot + 1, target);
                }
                else
                {
                    index = Array.BinarySearch(nums, pivot + 1, nums.Length - 1 - pivot, target);
                }
            }

            // Return the index if target is in the nums, otherwise, return -1
            return index >= 0 ? index : -1;
        }

        public static int FindPivot(int[] nums)
        {
            int left = 0, right = nums.Length - 1;

            // Return -1 if the input array is not rotated
            if (nums[right] >= nums[left]) return -1;

            // Use binary search to find the pivot
            // if the input nums is [4,5,6,7,0,1,2], then pivot is 3, i.e., index of the largest number
            int middle = 0;
            while (right >= left)
            {
                middle = left + (right - left) / 2;
                if (middle == left) break;

                if (nums[left] > nums[middle])
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
            }
            return left;
        }
    }
}
