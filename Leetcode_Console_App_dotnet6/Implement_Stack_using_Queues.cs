using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Implement_Stack_using_Queues
    {
        /* Problem link: https://leetcode.com/problems/implement-stack-using-queues/
         */

        Queue<int> que = new Queue<int>();
        /** Initialize your data structure here. */
        public Implement_Stack_using_Queues()
        {

        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            var tempQueue = new Queue<int>();
            tempQueue.Enqueue(x);

            while (que.Any())
            {
                tempQueue.Enqueue(que.Dequeue());
            }
            que = tempQueue;
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return que.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return que.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return !que.Any();
        }
    }
}
