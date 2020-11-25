using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Convert_Sorted_Array_to_Binary_Search_Tree
    {
        //Problem link: https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            return sortArrayToBST(nums, 0, nums.Length - 1);
        }

        public virtual TreeNode sortArrayToBST(int[] arr, int start, int end)
        {
            /* Base Case */
            if (start > end)
            {
                return null;
            }

            /* Get the middle element and make it root */
            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(arr[mid]);

            /* Recursively construct the left subtree and make it  
             left child of root */
            node.left = sortArrayToBST(arr, start, mid - 1);

            /* Recursively construct the right subtree and make it  
             right child of root */
            node.right = sortArrayToBST(arr, mid + 1, end);

            return node;
        }
    }
}
