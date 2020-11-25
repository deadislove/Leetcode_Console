using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Minimum_Depth_of_Binary_Tree
    {
        //Problem link: https://leetcode.com/problems/minimum-depth-of-binary-tree/

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

        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;

            if (root.left == null)
                return MinDepth(root.right) + 1;
            if (root.right == null)
                return MinDepth(root.left) + 1;

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}
