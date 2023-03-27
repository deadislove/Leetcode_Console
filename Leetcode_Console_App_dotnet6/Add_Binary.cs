using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Add_Binary
    {
        //Problem link: https://leetcode.com/problems/add-binary/

        public string AddBinary(string a, string b)
        {
            char[] sum = new char[Math.Max(a.Length, b.Length) + 1];
            bool carry = false;

            if (b.Length > a.Length)
            {
                string c = a;
                a = b;
                b = c;
            }

            for (int i = a.Length - 1, j = b.Length - 1, k = sum.Length - 1; i >= 0; i--, j--, k--)
            {
                char numA = a[i];
                char numB = j >= 0 ? b[j] : '0';

                Console.WriteLine(numA + " " + numB);

                if (carry)
                {
                    sum[k] = numA == numB ? '1' : '0';
                    carry = numA == '1' || numB == '1';
                }
                else
                {
                    sum[k] = numA == numB ? '0' : '1';
                    carry = numA == '1' && numB == '1';
                }
            }

            if (carry)
            {
                sum[0] = '1';
                return new string(sum);
            }

            return new string(sum, 1, sum.Length - 1);
        }
    }
}
