using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Length_of_Last_Word
    {
        //Problem link: https://leetcode.com/problems/length-of-last-word/

        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            string str = s.Trim();
            int len = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    len = 0;
                }
                else
                    len++;
            }

            return len;
        }
    }
}
