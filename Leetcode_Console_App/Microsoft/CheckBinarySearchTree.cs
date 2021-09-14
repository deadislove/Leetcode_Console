using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App.Microsoft
{
    public class CheckBinarySearchTree
    {
        //Root of the Binary Tree
        public Node root;

        /* 
         * can give min and max value according to your code or 
         * can write a function to find min and max value of tree. 
         */

        /* 
         * returns true if given search tree is binary search tree (efficient version) 
         */
        public virtual bool BinarySearchTree
        {
            get
            {
                return isBinarySearchTree(root, int.MinValue, int.MaxValue);
            }
        }

        /* 
         * Returns true if the given tree is a BST and its 
         * values are >= min and <= max. 
         */
        private bool isBinarySearchTree(Node node, int min, int max)
        {
            /* 
             * an empty tree is BST 
             */
            if (node is null)
                return true;

            /* 
             * false if this node violates the min/max constraints 
             */
            if (node.data < min || node.data > max)
                return false;

            /* 
             * otherwise check the subtrees recursively 
             * tightening the min/max constraints 
             */

            // Allow only distinct values
            return (
                isBinarySearchTree(node.left, min, node.data - 1) &&
                isBinarySearchTree(node.right, node.data + 1, max)
                );
        }

        public static void Client()
        {
            CheckBinarySearchTree tree = new CheckBinarySearchTree();
            tree.root = new Node(4);
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);

            if (tree.BinarySearchTree)
                Console.WriteLine("IS Binary Search Tree");
            else
                Console.WriteLine("Not a Binary Search Tree");
        }
    }

    // C# implementation to check if given Binary tree
    //is a BST or not

    /* 
     * Class containing left and right child of current node and key value
     */
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
}
