using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Happy_Number
    {
        //Problem link: https://leetcode.com/problems/happy-number/
        /* Solution reference link: https://www.geeksforgeeks.org/happy-number/
         */

        public bool IsHappy(int n)
        {
            int slow, fast;

            // initialize slow and 
            // fast by n 
            slow = fast = n;
            do
            {

                // move slow number 
                // by one iteration 
                slow = numSquareSum(slow);

                // move fast number 
                // by two iteration 
                fast = numSquareSum(numSquareSum(fast));

            }
            while (slow != fast);

            // if both number meet at 1, 
            // then return true 
            return (slow == 1);
        }

        public virtual int numSquareSum(int n)
        {
            int squareSum = 0;
            while (n != 0)
            {
                squareSum += (n % 10) *
                             (n % 10);
                n /= 10;
            }
            return squareSum;
        }
    }
}
