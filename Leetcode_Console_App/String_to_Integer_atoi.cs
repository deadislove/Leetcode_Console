using System;
using System.Collections.Generic;

namespace Leetcode_Console_App
{
    public static class String_to_Integer_atoi
    {
        public static void Client() {
            List<string> inputList = new List<string>();
            inputList.Add("42");
            inputList.Add("   -42");
            inputList.Add("4193 with words");

            foreach (var item in inputList) {
                var result = MyAtoi(item);
                Console.WriteLine(result);
            }
        }

        public static int MyAtoi(string s)
        {
            List<char> chars = new List<char>();
            s = s.TrimStart(' ');
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    chars.Add(s[i]);
                    continue;
                }
                if (i == 0 && s[0] == '-')
                    continue;
                if (i == 0 && s[0] == '+')
                    continue;
                break;
            }
            if (chars.Count == 0)
                return 0;
            bool cor = int.TryParse(String.Join("", chars), out int result);
            if (cor && s[0] == '-')
                return -result;
            if (cor)
                return result;
            if (!cor && s[0] == '-')
                return int.MinValue;
            else
                return int.MaxValue;
        }
    }
}
