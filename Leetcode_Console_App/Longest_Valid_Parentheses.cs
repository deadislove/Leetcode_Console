using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode_Console_App
{
    internal static class Longest_Valid_Parentheses
    {
        public static void Client() {
            string s = "((()";
            var result = LongestValidParentheses(s);
            Console.WriteLine(result);
        }

        // Brute Force
        public static int LongestValidParentheses(string s)
        {
            Stack<int> index = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    index.Push(i);
                }
                else
                {
                    if (index.Any() && s[index.Peek()] == '(')
                    {
                        index.Pop();
                    }
                    else
                    {
                        index.Push(i);
                    }
                }
            }
            if (!index.Any())
            {
                return s.Length;
            }
            int length = s.Length, unwanted = 0;
            int result = 0;
            while (index.Any())
            {
                unwanted = index.Peek();
                index.Pop();
                result = Math.Max(result, length - unwanted - 1);
                length = unwanted;
            }
            result = Math.Max(result, length);
            return result;
        }
    }
}
