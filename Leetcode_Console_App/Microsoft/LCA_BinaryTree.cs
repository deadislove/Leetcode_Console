using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App.Microsoft
{
    public class LCA_BinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        /// <summary>
        /// Leetcode solution
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == p || root == q || root is null)
                return root;

            TreeNode l = LowestCommonAncestor(root.left, p, q),
                     r = LowestCommonAncestor(root.right, p, q);

            return l != null && r != null ? root : l is null ? r : l;
        }

        // Geeksforgeeks solution
        // c# implementation to find lowest common ancestor of
        // n1 and n2 using one traversal of binary tree
        // It also handles cases even when n1 and n2 are not there in Tree

        /* Class containing left and right child of current node and key */
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

        // Root of the Binary Tree
        public Node root;
        public static bool v1 = false, v2 = false;

        // This function returns pointer to LCA of two given
        // values n1 and n2.
        // v1 is set as true by this function if n1 is found
        // v2 is set as true by this function if n2 is found
        public virtual Node findLCAUtil(Node node, int n1, int n2)
        {
            // Base case
            if (node == null)
            {
                return null;
            }

            //Store result in temp, in case of key match so that we can search for other key also.
            Node temp = null;

            // If either n1 or n2 matches with root's key, report the presence
            // by setting v1 or v2 as true and return root (Note that if a key
            // is ancestor of other, then the ancestor key becomes LCA)
            if (node.data == n1)
            {
                v1 = true;
                temp = node;
            }
            if (node.data == n2)
            {
                v2 = true;
                temp = node;
            }

            // Look for keys in left and right subtrees
            Node left_lca = findLCAUtil(node.left, n1, n2);
            Node right_lca = findLCAUtil(node.right, n1, n2);

            if (temp != null)
            {
                return temp;
            }

            // If both of the above calls return Non-NULL, then one key
            // is present in once subtree and other is present in other,
            // So this node is the LCA
            if (left_lca != null && right_lca != null)
            {
                return node;
            }

            // Otherwise check if left subtree or right subtree is LCA
            return (left_lca != null) ? left_lca : right_lca;
        }

        // Finds lca of n1 and n2 under the subtree rooted with 'node'
        public virtual Node findLCA(int n1, int n2)
        {
            // Initialize n1 and n2 as not visited
            v1 = false;
            v2 = false;

            // Find lca of n1 and n2 using the technique discussed above
            Node lca = findLCAUtil(root, n1, n2);

            // Return LCA only if both n1 and n2 are present in tree
            if (v1 && v2)
            {
                return lca;
            }

            // Else return NULL
            return null;
        }

        public static void Client()
        {
            LCA_BinaryTree tree = new LCA_BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);

            Node lca = tree.findLCA(4, 5);
            if (lca != null)
            {
                Console.WriteLine("LCA(4, 5) = " + lca.data);
            }
            else
            {
                Console.WriteLine("Keys are not present");
            }

            lca = tree.findLCA(4, 10);
            if (lca != null)
            {
                Console.WriteLine("LCA(4, 10) = " + lca.data);
            }
            else
            {
                Console.WriteLine("Keys are not present");
            }
        }
    }
}
