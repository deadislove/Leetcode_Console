﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Count_Primes
    {
        /* Problem link: https://leetcode.com/problems/count-primes/
         */

        public int CountPrimes(int n)
        {
            bool[] notPrime = new bool[n];
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (notPrime[i] == false)
                {
                    count++;
                    for (int j = 2; i * j < n; j++)
                    {
                        notPrime[i * j] = true;
                    }
                }
            }

            return count;
        }        
    }
}
