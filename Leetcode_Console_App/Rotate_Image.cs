namespace Leetcode_Console_App
{
    internal static class Rotate_Image
    {
        public static void Client() {
            int[][] intputArr = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9}
            };

            Rotate(intputArr);
        }

        // Reference: https://leetcode.com/problems/rotate-image/solutions/627014/c-simple-solution-which-beats-99-4/?orderBy=most_votes&languageTags=csharp
        public static void Rotate(int[][] matrix)
        {
            int width = matrix.Length;
            if (width < 2)
                return;

            for (int row = 0; row < width / 2; row++)
                for (int col = row; col < width - row - 1; col++)
                {
                    var last = matrix.Length - 1;
                    var tmp = matrix[col][last - row];
                    matrix[col][last - row] = matrix[row][col];
                    matrix[row][col] = matrix[last - col][row];
                    matrix[last - col][row] = matrix[last - row][last - col];
                    matrix[last - row][last - col] = tmp;
                }
        }
    }
}
