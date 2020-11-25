using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Climbing_Stairs
    {
        //Problem link: https://leetcode.com/problems/climbing-stairs/

        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;
            int[] count = new int[3];
            count[1] = 1;
            count[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                count[i % 3] = count[(i + 1) % 3] + count[(i - 1) % 3];
            }
            return count[n % 3];
        }
    }
}
