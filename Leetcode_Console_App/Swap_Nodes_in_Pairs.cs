using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App {
    public static class Swap_Nodes_in_Pairs {
        public static void Client() {}

        public class ListNode
        {
            public int val;
            public ListNode next;
            publicListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode SwapPairs(ListNode head)
        {
            ListNode prev = new ListNode();
            var a = head;
            var b = head?.next;

            head = b ?? a;

            while(a != null && b != null) {
                //swap the nodes
                (prev.next, a.next, b.next) = (b, b.next, a);
                // move on
                (prev, a, b) = (a, a.next, a.next?.next);
            }

            return head;
        }
    }
}