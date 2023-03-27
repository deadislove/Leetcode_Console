using System;

namespace Leetcode_Console_App
{
    public static class Zigzag_Conversion
    {
        public static void Client() {
            string inputStr = "PAYPALISHIRING";
            int inputNumRows = 3;

            // Case 1
            var result = Convert(inputStr, inputNumRows);
            Console.WriteLine(result);

        }

        // Reference link: https://leetcode.com/problems/zigzag-conversion/solutions/3434/solution-of-csharp/?orderBy=most_votes&languageTags=csharp
        public static string Convert(string s, int numRows)
        {
            string[] str = new string[numRows];  //each string represent a line
            for (int i = 0; i < str.Length; i++) str[i] = "";
            for (int i = 0; i < s.Length;)
            {
                for (int m = 0; m < numRows && i < s.Length; m++)
                {
                    str[m] += s[i++];         //down
                }
                for (int n = numRows - 2; n > 0 && i < s.Length; n--)
                {
                    str[n] += s[i++];        //right - top
                }
            }
            string result = "";
            foreach (string ss in str) result += ss;
            return result;
        }

    }
}
