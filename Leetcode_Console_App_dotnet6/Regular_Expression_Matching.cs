using System;
using System.Collections.Generic;

namespace Leetcode_Console_App
{
    public static class Regular_Expression_Matching
    {
        public static void Client() {
            List<Tuple<string, string>> inputArr = new List<Tuple<string, string>>();
            inputArr.Add(Tuple.Create("aa","a"));
            inputArr.Add(Tuple.Create("aa", "a*"));
            inputArr.Add(Tuple.Create("ab", ".*"));

            foreach (var item in inputArr) {
                var result = IsMatch(item.Item1, item.Item2);
                Console.WriteLine(result);
            }
        }


        // Reference link: https://leetcode.com/problems/regular-expression-matching/solutions/425444/c-solution/?q=C%23&orderBy=most_relevant
        /*
         * Dynamic Programming - Bottom-up variation
         */
        public static bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(p))
                return string.IsNullOrEmpty(s);
            var dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;
            for (int i = 2; i <= p.Length; i++)
                dp[0, i] = p[i - 1] == '*' && dp[0, i - 2];

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                        dp[i, j] = dp[i - 1, j - 1];
                    else if (p[j - 1] == '*')
                        dp[i, j] = dp[i, j - 2] || ((s[i - 1] == p[j - 2] || p[j - 2] == '.') && dp[i - 1, j]);
                }
            }

            return dp[s.Length, p.Length];
        }

        /*
         * Dynamic Programming - Top-Down Variation
         */
        public static bool IsMatch2(string s, string p)
        {
            Top_Down_Variation top_Down_Variation = new Top_Down_Variation();
            return top_Down_Variation.IsMatch(s, p);
        }
    }

    public class Top_Down_Variation {
        enum Result
        {
            TRUE, FALSE
        }

        Result[,] memo;

        public bool IsMatch(string s, string p) {
            memo = new Result[s.Length + 1, p.Length + 1];
            return dp(0, 0, s, p);
        }

        public bool dp(int i, int j, string text, string pattern)
        {
            if (memo[i, j] != null) return memo[i,j] == Result.TRUE;

            bool ans;

            if (j == pattern.Length) ans = i == text.Length;
            else {
                bool fisrt_match = (i < text.Length && (
                    pattern[j] == text[i] ||
                    pattern[j] == '.'
                    ));

                if (j + 1 < pattern.Length && pattern[j + 1] == '*')
                {
                    ans = (dp(i, j + 2, text, pattern) ||
                        fisrt_match && dp(i + 1, j, text, pattern));
                }
                else {
                    ans = fisrt_match && dp(i + 1, j + 1, text, pattern);
                }
            }

            memo[i, j] = ans ? Result.TRUE : Result.FALSE;
            return ans;
        }
    }
}
