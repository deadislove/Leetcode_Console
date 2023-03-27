using System.Collections.Generic;

namespace Leetcode_Console_App
{
    internal static class Sudoku_Solver
    {
        public static void Client() { }

        // Reference: https://leetcode.com/problems/sudoku-solver/solutions/690044/c-recursive-dfs-backtracking-solution-using-hashsets/
        public static void SolveSudoku(char[][] board)
        {
            HashSet<int>[] rows = new HashSet<int>[9];
            for (int i = 0; i < 9; i++)
                rows[i] = new HashSet<int>() { 9};
            HashSet<int>[] cols = new HashSet<int>[9];
            for (int i = 0; i < 9; i++)
                cols[i] = new HashSet<int>() { 9};
            HashSet<int>[] squares = new HashSet<int>[9];
            for (int i = 0; i < 9; i++)
                squares[i] = new HashSet<int>() { 9};

            // Fill up hashsets
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                        continue;
                    int number = board[i][j] - '0';
                    rows[i].Add(number);
                    cols[j].Add(number);
                    int s = (i / 3) * 3 + (j / 3);
                    squares[s].Add(number);
                }
            }

            // Solve sudoku
            Solve(board, rows, cols, squares, 0, 0);
        }

        private static bool Solve(char[][] board,
                         HashSet<int>[] rows,
                         HashSet<int>[] cols,
                         HashSet<int>[] squares,
                         int i,
                         int j)
        {
            for (int k = i; k < 9; k++)
            {
                for (int l = j; l < 9; l++)
                {
                    if (board[k][l] != '.')
                        continue;
                    for (int n = 1; n <= 9; n++)
                    {
                        if (!rows[k].Contains(n) &&
                            !cols[l].Contains(n) &&
                            !squares[(k / 3) * 3 + (l / 3)].Contains(n))
                        {

                            board[k][l] = (char)('0' + n);
                            rows[k].Add(n);
                            cols[l].Add(n);
                            squares[(k / 3) * 3 + (l / 3)].Add(n);

                            if (Solve(board, rows, cols, squares, k, l))
                                return true;

                            board[k][l] = '.';
                            rows[k].Remove(n);
                            cols[l].Remove(n);
                            squares[(k / 3) * 3 + (l / 3)].Remove(n);
                        }
                    }
                    if (board[k][l] == '.')
                        return false;
                }
                j = 0;
            }
            return true;
        }
    }
}
