﻿using System;
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

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }

            if (p.val == q.val)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
            else
            {
                return false;
            }
        }
    }
}
