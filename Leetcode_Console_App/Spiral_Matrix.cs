using System.Collections.Generic;

namespace Leetcode_Console_App
{
    internal static class Spiral_Matrix
    {
        public static void Client() {
            int[][] inputArr = new int[][] { 
                new int[] { 1, 2, 3},
                new int[] { 4, 5, 6},
                new int[] { 7, 8, 9}
            };

            var result = SpiralOrder(inputArr);
        }

        public static IList<int> SpiralOrder(int[][] matrix)
        {
            int matrixHeight = matrix.Length;
            if (matrixHeight == 0)
                return new int[0];
            int matrixWidth = matrix[0].Length;

            int[] res = new int[matrixWidth * matrixHeight];  //result array

            int topRow = 0;
            int bottomRow = matrixHeight - 1;
            int leftCol = 0;
            int rightCol = matrixWidth - 1;

            int idx = 0;  //current index in the result array
            while (leftCol <= rightCol && topRow <= bottomRow)
            {
                //iterate matrix row from left to right
                for (int i = leftCol; i <= rightCol; i++)
                    res[idx++] = matrix[topRow][i];
                topRow++;

                //iterate matrix column from top to bottom
                for (int i = topRow; i <= bottomRow; i++)
                    res[idx++] = matrix[i][rightCol];
                rightCol--;

                //iterate matrix row from right to left
                if (topRow <= bottomRow) //test case [[1,2]]
                {
                    for (int i = rightCol; i >= leftCol; i--)
                        res[idx++] = matrix[bottomRow][i];
                    bottomRow--;
                }

                //iterate matrix column from bottom to the top
                if (leftCol <= rightCol) //test case [[7],[9],[6]]
                {
                    for (int i = bottomRow; i >= topRow; i--)
                        res[idx++] = matrix[i][leftCol];
                    leftCol++;
                }
            }
            return res;
        }
    }
}
