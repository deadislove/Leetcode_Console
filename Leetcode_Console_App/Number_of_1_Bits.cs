using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Number_of_1_Bits
    {
        //Problem link: https://leetcode.com/problems/number-of-1-bits/

        public int HammingWeight(uint n)
        {
            uint count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return (int)count;
        }
    }
}
