using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode_Console_App
{
    public static class Generate_Parentheses
    {
        public static void Client() { }

        // Reference link: https://leetcode.com/problems/generate-parentheses/editorial/

        // Approach 3: Closure Number
        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> ans = new List<string>();

            if (n.Equals(0)) ans.Add("");
            else {
                for (int c = 0; c < n; c++) {
                    foreach (var left in GenerateParenthesis(c)) {
                        foreach (var right in GenerateParenthesis(n - 1 - c)) {
                            ans.Add("(" + left + ")" + right);
                        }
                    }
                }
            }

            return ans;
        }

        public static List<String> GenerateParenthesis2(int n)
        {
            List<string> ans = new List<string>();
            backtrack(ans, new StringBuilder(), 0, 0, n);
            return ans;
        }

        public static void backtrack(List<string> ans, StringBuilder cur, int open, int close, int max)
        {
            if (cur.Length == max * 2)
            {
                ans.Add(cur.ToString());
                return;
            }

            if (open < max)
            {
                cur.Append("(");
                backtrack(ans, cur, open + 1, close, max);
                cur.Remove(cur.Length - 1, "(".Length);
            }
            if (close < open)
            {
                cur.Append(")");
                backtrack(ans, cur, open, close + 1, max);
                cur.Remove(cur.Length - 1, ")".Length);
            }
        }
    }
}
