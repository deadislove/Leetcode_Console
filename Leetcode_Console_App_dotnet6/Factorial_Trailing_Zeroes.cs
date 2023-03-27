using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Factorial_Trailing_Zeroes
    {
        public int TrailingZeroes(int n)
        {
            int count = 0;

            // 5 bit
            for (int i = 5; n / i >= 1; i *= 5)
            {
                count += n / i;
            }

            return count;
        }
    }
}
