using System;
using System.Collections.Generic;

namespace Leetcode_Console_App
{
    public static class Longest_Substring_Without_Repeating_Characters
    {
        public static void Client() {

            string[] inputArr = new string[] { "abcabcbb", "bbbbb", "pwwkew" };

            foreach (var item in inputArr) {
                var output = 0;
                output = LengthOfLongestSubstring1(item);
                Console.WriteLine(output);
            }
        }

        // C# - HashSet
        // Reference link: https://leetcode.com/problems/longest-substring-without-repeating-characters/solutions/2989526/c-java-python3-javascript-solutions-easy/
        public static int LengthOfLongestSubstring1(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            HashSet<char> hSet = new HashSet<char>();
            int max = 0;
            int i = 0;
            int j = 0;

            while (i < s.Length)
            {
                if (!hSet.Contains(s[i]))
                {
                    hSet.Add(s[i]);
                    i++;
                }
                else
                {
                    max = Math.Max(max, hSet.Count);
                    hSet.Remove(s[j]);
                    j++;
                }
            }

            max = Math.Max(max, hSet.Count);
            return max;
        }

        // Approach 1: Sliding Window
        // Reference link: https://leetcode.com/problems/longest-substring-without-repeating-characters/solutions/1217675/2-straightforward-c-solutions-w-explanation-sliding-window/
        public static int LengthOfLongestSubstring2(string s)
        {
            var letters = new Dictionary<char, int>(); // key:letter, val: latest index
            int maxCount = 0, left = 0, right;

            for (right = 0; right < s?.Length; right++)
            {
                char letter = s[right];

                if (letters.ContainsKey(letter))
                { // End the window
                    left = Math.Max(left, letters[letter] + 1); // Update left of window
                }

                letters[letter] = right; //Update index of letter on map

                maxCount = Math.Max(maxCount, right - left + 1); // Get the longest window length 
            }

            return maxCount;
        }
    }
}
