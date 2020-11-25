using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Intersection_of_Two_Linked_Lists
    {
        //Problem link: https://leetcode.com/problems/intersection-of-two-linked-lists/

        /* 
         * 1, Get the length of the two lists.
         * 2, Align them to the same start point.
         * 3, Move them together until finding the intersection point, or the end null
         */
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int lenA = Length(headA), lenB = Length(headB);

            while (lenA > lenB)
            {
                headA = headA.next;
                lenA--;
            }

            while (lenA < lenB)
            {
                headB = headB.next;
                lenB--;
            }

            while (headA != headB)
            {
                headA = headA.next;
                headB = headB.next;
            }

            return headA;
        }

        private int Length(ListNode node)
        {
            int length = 0;
            while (node != null)
            {
                node = node.next;
                length++;
            }

            return length;
        }
    }
}
