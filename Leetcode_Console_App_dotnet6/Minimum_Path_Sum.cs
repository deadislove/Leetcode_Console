using System;

namespace Leetcode_Console_App
{
    internal static class Minimum_Path_Sum
    {
        public static void Client() { }

        public static int MinPathSum(int[][] grid)
        {
            int rows = grid.Length;
            if (rows == 0)
                return 0;
            int cols = grid[0].Length;
            if (cols == 0)
                return 0;

            int[][] dp = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                dp[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 && j == 0)
                        dp[i][j] = grid[i][j];
                    else if (i == 0)
                        dp[i][j] = grid[i][j] + dp[i][j - 1];
                    else if (j == 0)
                        dp[i][j] = grid[i][j] + dp[i - 1][j];
                    else
                        dp[i][j] = grid[i][j] + Math.Min(dp[i - 1][j], dp[i][j - 1]);
                }
            }

            return dp[rows - 1][cols - 1];

        }

        public static int MinPathSum2(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    if (i == 0)
                    {
                        grid[i][j] += grid[i][j - 1];
                        continue;
                    }

                    if (j == 0)
                    {
                        grid[i][j] += grid[i - 1][j];
                        continue;
                    }

                    grid[i][j] += Math.Min(grid[i][j - 1], grid[i - 1][j]);
                }
            }

            return grid[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
