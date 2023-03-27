using System;
using System.Linq;

namespace Leetcode_Console_App
{
    public static class Reverse_Integer
    {

        public static void Client() {

            int input = 123;
            var result = Reverse(input);
            Console.WriteLine(result);
        }

        //Problem link: https://leetcode.com/problems/reverse-integer/

        public static long Reverse(int x)
        {
            string str = new string(x.ToString().Trim('-').Reverse().ToArray());
            bool tryInt32 = int.TryParse(str, out int intValue);
            return tryInt32 ? x.ToString().Contains("-") ? intValue * -1 : intValue : 0;
        }
    }
}
