using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{   
    class Reverse_Linked_List
    {
        /* Problem link: https://leetcode.com/problems/reverse-linked-list/
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

        public ListNode ReverseList(ListNode head)
        {
            ListNode newNode = null;
            while (head != null) {
                ListNode next = head.next;
                head.next = newNode;
                newNode = head;
                head = next;
            }
            return newNode;
        }

        // Note
        private ListNode reverseListInt(ListNode head, ListNode newHead)
        {
            if (head == null)
                return newHead;
            ListNode next = head.next;
            head.next = newHead;
            return reverseListInt(next, head);
        }
    }
}
