using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App.Microsoft
{
    public class ConnectNodeAtSameLevel
    {
        // Definition for a Node.
        private class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

        Node root;

        void Connect(Node root)
        {
            // initialize queue to hold nodes at same level
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root); // adding nodes to tehe queue

            Node temp = null; // initializing prev to null
            while (q.Count > 0)
            {
                int n = q.Count;
                for (int i = 0; i < n; i++)
                {
                    Node prev = temp;
                    temp = q.Dequeue();

                    // i > 0 because when i is 0 prev points
                    // the last node of previous level,
                    // so we skip it
                    if (i > 0)
                        prev.next = temp;

                    if (temp.left != null)
                        q.Enqueue(temp.left);

                    if (temp.right != null)
                        q.Enqueue(temp.right);
                }

                // pointing last node of the nth level to null
                temp.next = null;
            }
        }

        // Driver code
        public static void Main(String[] args)
        {
            ConnectNodeAtSameLevel tree = new ConnectNodeAtSameLevel();

            /* Constructed binary tree is
                10
                / \
            8     2
            /
            3
            */
            tree.root = new Node(10);
            tree.root.left = new Node(8);
            tree.root.right = new Node(2);
            tree.root.left.left = new Node(3);

            // Populates nextRight pointer in all nodes
            tree.Connect(tree.root);

            // Let us check the values of nextRight pointers
            Console.WriteLine("Following are populated nextRight pointers in "
                            + "the tree"
                            + "(-1 is printed if there is no nextRight)");
            int a = tree.root.next != null ? tree.root.next.val : -1;
            Console.WriteLine("nextRight of " + tree.root.val + " is "
                            + a);
            int b = tree.root.left.next != null ? tree.root.left.next.val : -1;
            Console.WriteLine("nextRight of " + tree.root.left.val + " is "
                            + b);
            int c = tree.root.right.next != null ? tree.root.right.next.val : -1;
            Console.WriteLine("nextRight of " + tree.root.right.val + " is "
                            + c);
            int d = tree.root.left.left.next != null ? tree.root.left.left.next.val : -1;
            Console.WriteLine("nextRight of " + tree.root.left.left.val + " is "
                            + d);
        }
    }
}
