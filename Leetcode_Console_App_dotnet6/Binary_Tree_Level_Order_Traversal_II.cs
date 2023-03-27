using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Binary_Tree_Level_Order_Traversal_II
    {
        //Problem list:https://leetcode.com/problems/binary-tree-level-order-traversal-ii/

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

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            //Breadth-first Search
            if (root == null)
                return new List<IList<int>>();

            List<IList<int>> result = new List<IList<int>>();

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var list = new List<int>();
                var currentLevelNumver = queue.Count;

                for (int i = 0; i < currentLevelNumver; i++)
                {
                    var node = queue.Dequeue();
                    list.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                result.Insert(0, list);
            }

            return result;
        }
    }
}
