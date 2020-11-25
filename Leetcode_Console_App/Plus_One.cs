using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Plus_One
    {
        //Problem link: https://leetcode.com/problems/plus-one/

        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0)
                return new int[0];

            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;

                if (sum >= 10)
                {
                    carry = 1;
                }
                else
                    carry = 0;

                digits[i] = sum % 10;
            }

            if (carry == 1)
            {
                int[] result = new int[digits.Length + 1];
                Array.ConstrainedCopy(digits, 0, result, 1, digits.Length);
                result[0] = 1;
                return result;
            }
            else
                return digits;
        }
    }
}
