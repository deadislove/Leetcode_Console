using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Implement_Queue_using_Stacks
    {

        /* Problem link: https://leetcode.com/problems/implement-queue-using-stacks/
         */

        Stack<int> stack = new Stack<int>();

        /** Initialize your data structure here. */
        public Implement_Queue_using_Stacks()
        {

        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            var newStack = new Stack<int>();
            while (stack.Any())
            {
                newStack.Push(stack.Pop());
            }
            newStack.Push(x);

            while (newStack.Any())
            {
                stack.Push(newStack.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return stack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return stack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return !stack.Any();
        }
    }
}
