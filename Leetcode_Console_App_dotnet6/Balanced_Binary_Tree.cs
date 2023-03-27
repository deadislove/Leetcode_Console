using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Balanced_Binary_Tree
    {
        //Problem link: https://leetcode.com/problems/balanced-binary-tree/

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

        public bool IsBalanced(TreeNode root)
        {
            int lh; // for height of left subtree 

            int rh; // for height of right subtree 

            /* If tree is empty then return true */
            if (root == null)
            {
                return true;
            }

            /* Get the height of left and right sub trees */
            lh = height(root.left);
            rh = height(root.right);

            if (Math.Abs(lh - rh) <= 1 && IsBalanced(root.left)
                && IsBalanced(root.right))
            {
                return true;
            }

            /* If we reach here then tree is not height-balanced */
            return false;
        }

        /* UTILITY FUNCTIONS TO TEST isBalanced() FUNCTION */
        /* The function Compute the "height" of a tree. Height is the  
            number of nodes along the longest path from the root node  
            down to the farthest leaf node.*/
        public virtual int height(TreeNode node)
        {
            /* base case tree is empty */
            if (node == null)
            {
                return 0;
            }

            /* If tree is not empty then height = 1 + max of left  
            height and right heights */
            return 1 + Math.Max(height(node.left), height(node.right));
        }
    }
}
