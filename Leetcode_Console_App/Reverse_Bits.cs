using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Reverse_Bits
    {
        // << and >> shift 1 unit.
        // Base on the 32 bit.

        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (var i = 0; i < 32; i++)
            {
                result = (result << 1) + (n & 1);
                n = n >> 1;
            }
            return result;
        }
    }
}
