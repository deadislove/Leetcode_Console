using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Min_Stack
    {
        //Problem link: https://leetcode.com/problems/min-stack/
        /* Reference
         * GeeksForgeeks solution
         * Link: https://www.geeksforgeeks.org/design-a-stack-that-supports-getmin-in-o1-time-and-o1-extra-space/
         */

        public class MinStack
        {
            public Stack s;
            public int minEle;
            /** initialize your data structure here. */
            public MinStack()
            {
                s = new Stack();
            }

            public void Push(int x)
            {
                if (s.Count == 0)
                {
                    minEle = x;
                    s.Push(x);
                    return;
                }

                if (x < minEle)
                {
                    s.Push(2 * x - minEle);
                    minEle = x;
                }
                else
                    s.Push(x);
            }

            public void Pop()
            {
                if (s.Count == 0)
                    return;
                int t = (int)s.Pop();

                if(t<minEle)
                    minEle = 2 * minEle - t;
            }

            public int Top()
            {
                return(int)s.Peek();
            }

            public int GetMin()
            {
                if (s.Count == 0)
                    return 0;
                else
                    return minEle;
            }
        }
    }
}
