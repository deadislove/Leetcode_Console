using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App.Microsoft
{
    public class AddTwoNumbers
    {
        public static ListNode AddTwoNumbersSolution(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode dummy = new ListNode(0);
            ListNode pre = dummy;

            while (l1 != null || l2 != null || carry == 1)
            {
                int sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
                carry = sum < 10 ? 0 : 1;
                pre.next = new ListNode(sum % 10);
                pre = pre.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            return dummy.next;
        }

        public static void Client()
        {
            int[] arr1 = { 2, 4, 3 };
            int[] arr2 = { 5, 6, 4 };

            ListNode l1 = new ListNode();
            ListNode l2 = new ListNode();
            for (int i = arr1.Length - 1; i >= 0; --i)
            {
                ListNode new_node = new ListNode(0)
                {
                    val = arr1[i],
                    next = l1
                };
                l1 = new_node;
            }

            for (int i = arr2.Length - 1; i >= 0; --i)
            {
                ListNode new_node = new ListNode(0)
                {
                    val = arr2[i],
                    next = l2
                };
                l2 = new_node;
            }

            var result = AddTwoNumbersSolution(l1, l2);

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
        }
    }

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
}