using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Sqrtx
    {
        //Problem link: https://leetcode.com/problems/sqrtx/

        public int MySqrt(int x)
        {
            long s = Convert.ToInt64(x);
            while (s * s > x)
                s = (s + x / s) / 2;
            return (int)s;
        }
    }
}
