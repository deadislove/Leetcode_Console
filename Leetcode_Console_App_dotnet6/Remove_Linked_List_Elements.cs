using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{    

    class Remove_Linked_List_Elements
    {
       /* Problem link: https://leetcode.com/problems/remove-linked-list-elements/
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


        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode helper = new ListNode(0)
            {
                next = head
            };
            ListNode p = helper;

            while (p.next != null)
            {
                if (p.next.val == val)
                {
                    ListNode next = p.next;
                    p.next = next.next;
                }
                else
                    p = p.next;
            }
            return helper.next;
        }
    }
}
