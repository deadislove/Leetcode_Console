using System.Collections.Generic;

namespace Leetcode_Console_App
{
    public static class Letter_Combinations_of_a_Phone_Number
    {
        public static void Client() { }

        // Reference link: https://leetcode.com/problems/letter-combinations-of-a-phone-number/solutions/1021905/c-simple-recursion-faster-than-86-46-less-memory-than-19-51/?orderBy=most_votes&languageTags=csharp
        public static IList<string> LetterCombinations(string digits)
        {
            string[] map = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            IList<string> result = new List<string>();
            result = dfs(result, map, digits);
            return result;
        }

        private static IList<string> dfs(IList<string> result, string[] map, string digits)
        {
            if (digits.Length == 0) return result;
            IList<string> aux = new List<string>();
            foreach (char c in map[digits[0] - '0'])
            {
                if (result.Count == 0)
                {
                    aux.Add(c.ToString());
                }
                else
                {
                    foreach (string r in result)
                        aux.Add(r + c);
                }
            }

            result = dfs(aux, map, digits.Remove(0, 1));

            return result;
        }
    }
}
