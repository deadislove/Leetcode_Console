using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Palindrome_Linked_List
    {
        /* Problem link: https://leetcode.com/problems/palindrome-linked-list/
         */

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

        public bool IsPalindrome(ListNode head)
        {
            ListNode fast = head, slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            if (fast != null)
                slow = slow.next;

            slow = reverse(slow);
            fast = head;

            while (slow != null)
            {
                if (fast.val != slow.val)
                    return false;
                fast = fast.next;
                slow = slow.next;
            }

            return true;
        }

        public ListNode reverse(ListNode head)
        {
            ListNode pre = null;
            while (head != null)
            {
                ListNode node = head.next;
                head.next = pre;
                pre = head;
                head = node;
            }

            return pre;
        }
    }
}
