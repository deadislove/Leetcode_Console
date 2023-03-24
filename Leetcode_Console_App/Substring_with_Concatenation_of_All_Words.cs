using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode_Console_App
{
    internal static class Substring_with_Concatenation_of_All_Words
    {
        public static void Client() {

            string s = "barfoothefoobarman";
            string[] words = new string[] { "foo", "bar" };

            var ans = FindSubstring(s, words);
            foreach (var i in ans)
                Console.WriteLine(i);
            
        }


        // Reference: https://leetcode.com/problems/substring-with-concatenation-of-all-words/solutions/2812038/c-simple-solution/
        public static IList<int> FindSubstring(string s, string[] words)
        {
            int oneWordLength = words[0].Length;
            int permLength = words.Length * oneWordLength;
            var result = new List<int>();

            int sLength = s.Length;

            for (int i = 0; i <= sLength - permLength; i++)
            {
                string temp = s.Substring(i, permLength);
                if (IsPerm(temp, words, oneWordLength, permLength))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private static bool IsPerm(string s, string[] words, int oneWordLength, int permLength)
        {
            bool result = true;
            int num = permLength / oneWordLength;
            List<string> wordList = words.ToList();

            for (int i = 0; i < num; i++)
            {
                int index = i * oneWordLength;
                string temp = s.Substring(index, oneWordLength);
                if (!wordList.Contains(temp))
                {
                    result = false;
                    break;
                }
                else
                {
                    wordList.Remove(temp);
                }
            }

            return result;
        }
    }
}
