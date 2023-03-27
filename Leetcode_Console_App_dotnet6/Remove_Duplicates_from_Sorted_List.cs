using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Remove_Duplicates_from_Sorted_List
    {
        //Problem link: https://leetcode.com/problems/remove-duplicates-from-sorted-list/

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

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            while (current != null && current.next != null)
            {
                if (current.next.val == current.val)
                {
                    current.next = current.next.next;
                }
                else
                    current = current.next;
            }

            return head;
        }
    }
}
