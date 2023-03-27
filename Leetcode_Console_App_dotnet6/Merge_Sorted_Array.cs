using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Merge_Sorted_Array
    {
        //Problem link: https://leetcode.com/problems/merge-sorted-array/

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1, tar = m + n - 1;

            while (j >= 0)
            {
                nums1[tar--] = i >= 0 && nums1[i] > nums2[j] ? nums1[i--] : nums2[j--];
            }
        }
    }
}
