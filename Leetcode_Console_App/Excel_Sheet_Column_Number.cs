using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Excel_Sheet_Column_Number
    {
        public int TitleToNumber(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result *= 26;
                result += (s[i] - 'A') + 1;
            }

            return result;
        }
    }
}
