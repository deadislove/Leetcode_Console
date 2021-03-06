﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Isomorphic_Strings
    {
        /* Problem link: https://leetcode.com/problems/isomorphic-strings/
         */

        public bool IsIsomorphic(string s, string t)
        {
            int[] m1 = new int[256];
            int[] m2 = new int[256];
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (m1[s[i]] != m2[t[i]])
                    return false;
                m1[s[i]] = i + 1;
                m2[t[i]] = i + 1;
            }
            return true;
        }
    }
}
