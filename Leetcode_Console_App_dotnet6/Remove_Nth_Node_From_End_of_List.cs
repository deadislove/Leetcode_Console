using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    public static class Remove_Nth_Node_From_End_of_List
    {
        public static void Client() { }

        // Definition for singly-linked list.
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

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head); // Create a dummy node
            ListNode slow = dummy, fast = dummy;

            // Gap of fast and slow is n
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            // Move slow to the node behind the node to delete
            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            // Delete the node
            slow.next = slow.next.next;

            return dummy.next;
        }
    }
}
