using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Maximum_Depth_of_Binary_Tree
    {
        //Problem link: https://leetcode.com/problems/maximum-depth-of-binary-tree/

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

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                int lDepth = MaxDepth(root.left);
                int rDepth = MaxDepth(root.right);

                if (lDepth > rDepth)
                    return lDepth + 1;
                else
                    return rDepth + 1;
            }
        }
    }
}
