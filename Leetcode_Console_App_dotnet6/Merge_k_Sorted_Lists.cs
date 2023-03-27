using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    public static class Merge_k_Sorted_Lists
    {
        public static void Client() { }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            var pq = new PriorityQueue<ListNode, int>();

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    pq.Enqueue(lists[i], lists[i].val);
                }
            }

            ListNode root = new ListNode(0, null);
            var current = root;

            while (pq.Count > 0)
            {
                var node = pq.Dequeue();
                if (node.next != null)
                {
                    pq.Enqueue(node.next, node.next.val);
                }
                current.next = new ListNode(node.val, null);
                current = current.next;
            }

            return root.next;
        }
    }
}
