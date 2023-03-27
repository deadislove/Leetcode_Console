namespace Leetcode_Console_App
{
    internal static class Spiral_Matrix_II
    {
        public static void Client() { }
        public static int[][] GenerateMatrix(int n)
        {
            int[,] result = new int[n, n];
            int cnt = 1;
            for (int layer = 0; layer < (n + 1) / 2; layer++)
            {
                // direction 1 - traverse from left to right
                for (int ptr = layer; ptr < n - layer; ptr++)
                {
                    result[layer, ptr] = cnt++;
                }
                // direction 2 - traverse from top to bottom
                for (int ptr = layer + 1; ptr < n - layer; ptr++)
                {
                    result[ptr, n - layer - 1] = cnt++;
                }
                // direction 3 - traverse from right to left
                for (int ptr = layer + 1; ptr < n - layer; ptr++)
                {
                    result[n - layer - 1, n - ptr - 1] = cnt++;
                }
                // direction 4 - traverse from bottom to top
                for (int ptr = layer + 1; ptr < n - layer - 1; ptr++)
                {
                    result[n - ptr - 1, layer] = cnt++;
                }
            }
            return ToJaggedArray(result);
        }

        static int[][] ToJaggedArray(this int[,] twoDimensionalArray)
        {
            int rowsFirstIndex = twoDimensionalArray.GetLowerBound(0);
            int rowsLastIndex = twoDimensionalArray.GetUpperBound(0);
            int numberOfRows = rowsLastIndex + 1;

            int columnsFirstIndex = twoDimensionalArray.GetLowerBound(1);
            int columnsLastIndex = twoDimensionalArray.GetUpperBound(1);
            int numberOfColumns = columnsLastIndex + 1;

            int[][] jaggedArray = new int[numberOfRows][];
            for (int i = rowsFirstIndex; i <= rowsLastIndex; i++)
            {
                jaggedArray[i] = new int[numberOfColumns];

                for (int j = columnsFirstIndex; j <= columnsLastIndex; j++)
                {
                    jaggedArray[i][j] = twoDimensionalArray[i, j];
                }
            }
            return jaggedArray;
        }
    }
}
