using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Invert_Binary_Tree
    {
        /* Problem link: https://leetcode.com/problems/invert-binary-tree/
         */

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

        /* Algorithm O(n)
         */
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode right = InvertTree(root.right);
            TreeNode left = InvertTree(root.left);
            root.left = right;
            root.right = left;

            return root;
        }        
    }
}
