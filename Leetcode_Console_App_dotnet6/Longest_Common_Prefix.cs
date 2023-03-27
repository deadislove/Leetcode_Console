using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Longest_Common_Prefix
    {
        //Problem link: https://leetcode.com/problems/longest-common-prefix/

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string Pre = strs[0];
            int i = 1;

            while (i < strs.Length)
            {
                while (strs[i].IndexOf(Pre) != 0)
                {
                    Pre = Pre.Substring(0, Pre.Length - 1);
                }

                i++;
            }

            return Pre;

        }
    }
}
