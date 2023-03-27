using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Path_Sum
    {
        //Problem link: https://leetcode.com/problems/path-sum/

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

        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            return DFS(sum, 0, root);
        }

        public virtual bool DFS(int target, int sum, TreeNode root)
        {
            if (root == null)
                return false;
            sum += root.val;
            if (root.left == null && root.right == null)
            {
                if (sum == target)
                    return true;
                else
                    return false;
            }
            bool leftPart = DFS(target, sum, root.left);
            bool rightPart = DFS(target, sum, root.right);
            return leftPart || rightPart;
        }
    }
}
