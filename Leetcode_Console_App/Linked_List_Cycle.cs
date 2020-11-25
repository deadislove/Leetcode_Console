using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Linked_List_Cycle
    {
        //Problem link: https://leetcode.com/problems/linked-list-cycle/

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> s = new HashSet<ListNode>();

            while (head != null)
            {
                // If we have already has this node 
                // in hashmap it means their is a cycle 
                // (Because you we encountering the 
                // node second time). 
                if (s.Contains(head))
                    return true;

                // If we are seeing the node for 
                // the first time, insert it in hash 
                s.Add(head);

                head = head.next;
            }

            return false;
        }
    }
}
