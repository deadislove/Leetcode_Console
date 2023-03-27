namespace Leetcode_Console_App
{
    internal static class Reverse_Nodes_in_k_Group
    {
        public static void Client() {

            ListNode input = new ListNode(1);
            input.val = 2;
            input.next = new ListNode(3);
            input.next.next = new ListNode(4);
            input.next.next.next = new ListNode(5);
        }

        /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k.Equals(0)) return head;
            if (head == null) return null;

            ListNode h = reverse(head, k);

            return h;
        }

        private static ListNode reverse(ListNode head, int k) {
            ListNode prev = null;
            ListNode next = null;
            ListNode curr = head;
            int c = 0;

            while(curr != null && c < k) {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                c++;
            }

            int len = 0;
            ListNode temp = next;
            while (temp != null) {
                len++;
                temp = temp.next;
            }

            if (next != null && len >= k)
            {
                head.next = reverse(next, k);
            }
            else
                head.next = next;

            return prev;
        }
    }
}
