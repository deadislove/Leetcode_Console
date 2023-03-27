using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Same_Tree
    {
        //Problem link: https://leetcode.com/problems/same-tree/

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

        /// <summary>
        /// Leetcode - Approach 1: Recursion
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;            
            else if (p == null || q == null)
                return false;

            if (p.val == q.val)
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            else
                return false;
        }

        /// <summary>
        /// Leetcode - Approach 2: Iteration
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTree2(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (!check(p, q))
                return false;

            LinkedList<TreeNode> deqP = new LinkedList<TreeNode>();
            LinkedList<TreeNode> deqQ = new LinkedList<TreeNode>();
            deqP.AddLast(p);
            deqQ.AddLast(q);

            while (deqP.Count() == 0)
            {
                deqP.RemoveFirst();
                deqQ.RemoveFirst();
                p = deqP.ToArray()[0];
                q = deqQ.ToArray()[0];

                if (!check(p, q))
                    return false;
                if (p != null)
                {
                    if (!check(p.left, q.left))
                        return false;
                    if (p.left != null)
                    {
                        deqP.AddLast(p.left);
                        deqQ.AddLast(q.left);
                    }

                    if (!check(p.right, q.right))
                        return false;
                    if (p.right != null)
                    {
                        deqP.AddLast(p.right);
                        deqQ.AddLast(q.right);
                    }
                }
            }
            return true;
        }

        private bool check(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return false;
            if (p == null || q == null)
                return false;
            if (p.val != q.val)
                return false;
            return true;
        }
    }
}
