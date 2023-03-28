namespace Leetcode_Console_App_dotnet6
{
    internal static class Rotate_List
    {
        public static void Client() { }

        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }

        /*
         * step 1 = count number of elements linked
         * step 2 = jump to first element of rotated
         * step 3 = jump to last element of rotated
         * step 4 = remove link of new_head from head at last element of list( reference of head )
         * step 6 = link list( reference of new_head ) to head( original head except new_head link ) at last element of list( reference of new_head )
         */

        public static ListNode RotateRight(ListNode head, int k)
        {
            // step 1 = count number of elements linked
            int length = getLength(head);

            k %= (length > 0) ? length : 1; // eliminates multiple passes
            if (k == 0 || head == null || head.next == null) return head;

            // step 2 = jump to first element of rotated
            ListNode new_head = head;
            int jumps = length - k;
            while (jumps-- > 0) new_head = new_head.next;

            // step 3 = jump to last element of rotated
            ListNode list = head;
            jumps = length - k - 1;
            while (jumps-- > 0) list = list.next;

            // step 4 = remove link of new_head from head
            // at last element of list( reference of head )
            list.next = null;

            // step 5 = move to last element of new_head
            list = new_head;
            while (list.next != null) list = list.next;

            // step 6 = link list( reference of new_head ) to head( original head except new_head link )
            // at last element of list( reference of new_head )
            list.next = head;

            return new_head;

        }

        private static int getLength(ListNode head)
        {
            int output = 0;
            for (; head != null; head = head.next, output++) { };
            return output;
        }
    }
}
