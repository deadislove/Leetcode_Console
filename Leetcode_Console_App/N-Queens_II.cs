using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    internal static class N_Queens_II
    {
        public static void Client() {
            var result = TotalNQueens(4);
        }

        static int count;
        static bool[] rows;
        static bool[] diag1;
        static bool[] diag2;
        static int _n;

        public static int TotalNQueens(int n)
        {
            count = 0;
            _n = n;
            rows = new bool[n];
            diag1 = new bool[2 * n];
            diag2 = new bool[2 * n];

            Helper(0);

            return count;
        }

        private static void Helper(int col)
        {
            if (col == _n) count++; // successfully placed n queens
                                   // in case col == n, we could return right away, but it is also alright to go on

            for (int row = 0; row < _n; row++)
            {
                int a = row + col;
                int b = row - col + _n;

                if (rows[row] || diag1[a] || diag2[b]) continue; // unable to place a queen

                rows[row] = diag1[a] = diag2[b] = true;  // place a queen
                Helper(col + 1);                         // go to the next column
                rows[row] = diag1[a] = diag2[b] = false; // remove the queen
            }
        }
    }
}
