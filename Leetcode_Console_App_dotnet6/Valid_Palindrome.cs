using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Valid_Palindrome
    {
        //Problem link: https://leetcode.com/problems/valid-palindrome/

        public bool IsPalindrome(string s)
        {
            if (s == null)
                return false;

            s = s.ToLower();
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                while (i < j && !((s[i]>='a' && s[i] <='z')  || (s[i]>='0' && s[i]<='9')))
                {
                    i++;
                }

                while (i < j && !((s[j] >= 'a' && s[j] <= 'z') || (s[j] >= '0' && s[j] <= '9')))
                {
                    j--;
                }

                if (s[i] != s[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
    }
}
