using System.Collections.Generic;

namespace Leetcode_Console_App
{
    internal static class Valid_Sudoku
    {
        public static void Client() { }

        // Reference: https://leetcode.com/problems/valid-sudoku/solutions/3172230/c-fastest-time-solution-but-worst-memory-complexity/
        public static bool IsValidSudoku(char[][] board)
        {
            // easy solution, worst memory complexity
            HashSet<char>[] rowHash = new HashSet<char>[9];
            HashSet<char>[] colHash = new HashSet<char>[9];
            // initialize row's and col's hashSets
            for (int i = 0; i < rowHash.Length; i++)
            {
                rowHash[i] = new HashSet<char>();
                colHash[i] = new HashSet<char>();
            }

            HashSet<char>[,] squareHash = new HashSet<char>[3, 3];
            // initialize squareHash's hashSets
            for (int row = 0; row < squareHash.GetLength(0); row++)
                for (int col = 0; col < squareHash.GetLength(1); col++)
                    squareHash[row, col] = new HashSet<char>();


            for (int row = 0; row < board.Length; row++)
                for (int col = 0; col < board.Length; col++)
                {
                    if (board[row][col] == '.')
                        continue;

                    if (rowHash[row].Contains(board[row][col]))
                        return false;
                    rowHash[row].Add(board[row][col]);

                    if (colHash[col].Contains(board[row][col]))
                        return false;
                    colHash[col].Add(board[row][col]);

                    if (squareHash[row / 3, col / 3].Contains(board[row][col]))
                        return false;
                    squareHash[row / 3, col / 3].Add(board[row][col]);
                }

            return true;
        }
    }
}
