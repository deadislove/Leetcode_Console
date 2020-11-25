using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Reverse_Integer
    {
        //Problem link: https://leetcode.com/problems/reverse-integer/

        public long Reverse(int x)
        {
            int itemp = Math.Abs(x);

            char[] c = itemp.ToString().ToCharArray();
            Array.Reverse(c);
            string result = new string(c);

            long Iresult = Convert.ToInt32(result);

            if (x < 0)
                Iresult = Iresult * -1;
            return Iresult;
        }
    }
}
