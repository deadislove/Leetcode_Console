using System;

namespace Leetcode_Console_App
{
    public static class Median_of_Two_Sorted_Arrays
    {
        public static void Client() {

            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { };

            // Case 1
            nums1 = new int[] { 1, 3 };
            nums2 = new int[] { 2 };
            // Case 2
            nums1 = new int[] { 1, 2 };
            nums2 = new int[] { 3, 4 };
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            if (len1 < len2) return FindMedianSortedArrays(nums2, nums1);
            int low = 0, high = len2 * 2;
            while (low <= high)
            {
                int mid2 = (low + high) / 2;
                int mid1 = len1 + len2 - mid2;
                double L1 = (mid1 == 0) ? Int32.MinValue : nums1[(mid1 - 1) / 2];
                double L2 = (mid2 == 0) ? Int32.MinValue : nums2[(mid2 - 1) / 2];
                double R1 = (mid1 == len1 * 2) ? Int32.MaxValue : nums1[(mid1) / 2];
                double R2 = (mid2 == len2 * 2) ? Int32.MaxValue : nums2[(mid2) / 2];
                if (L1 > R2) low = mid2 + 1;
                else if (L2 > R1) high = mid2 - 1;
                else
                    return (Math.Max(L1, L2) + Math.Min(R1, R2)) / 2;
            }
            return -1;
        }
    }
}
