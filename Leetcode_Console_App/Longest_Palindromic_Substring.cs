using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    public static class Longest_Palindromic_Substring
    {
        public static void Clietn() {
            string[] inputArr = new string[] { "babad", "cbbd" };

            foreach (var item in inputArr)
            {
                var output = string.Empty;
                output = LongestPalindrome(item);
                Console.WriteLine(output);
            }
        }

        public static string LongestPalindrome(string s)
        {
            int maxLength = 0, startIndex = 0;

            for (int i = 0; i < s.Length; i++) {
                int start = i, end = i;

                while(end < s.Length - 1 && s[start] == s[end + 1])
                    end++;

                while (end < s.Length - 1 && start > 0 && s[start - 1] == s[end + 1]) {
                    start--;
                    end++;
                }

                if (maxLength < end - start + 1) {
                    maxLength = end - start + 1;
                    startIndex = start;
                }
            }

            return s.Substring(startIndex, maxLength);
        }
    }
}
