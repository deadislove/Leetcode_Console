using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Valid_Parentheses
    {
        //Problem link: https://leetcode.com/problems/valid-parentheses/
        public bool IsValid(string s)
        {
            Stack<char> endings = new Stack<char>();

            foreach (var curr in s)
            {
                switch (curr)
                {
                    case '(':
                        endings.Push(')');
                        break;
                    case '[':
                        endings.Push(']');
                        break;
                    case '{':
                        endings.Push('}');
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (endings.Count == 0 || endings.Pop() != curr)
                            return false;
                        break;

                }
            }

            return endings.Count == 0;
        }
    }
}
