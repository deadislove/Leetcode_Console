using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Implement_strStr
    {
        //Problem link: https://leetcode.com/problems/implement-strstr/

        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) && !string.IsNullOrEmpty(needle))
                return -1;
            else if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
                return 0;


            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length > haystack.Length)
                    return -1;

                int m = i;

                for (int j = 0; j < needle.Length; j++)
                {
                    if (needle[j] == haystack[m])
                    {
                        if (j == needle.Length - 1)
                            return i;
                        m++;
                    }
                    else
                        break;
                }
            }
            return -1;
        }
    }
}
