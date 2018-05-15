using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class IsToeplitzMatrixSolution
    {
        public IsToeplitzMatrixSolution()
        {
            var matrix = new int[3, 7] { { 36, 59, 71, 15, 26, 82, 87 }, { 56, 36, 59, 71, 15, 26, 82 }, { 15, 0, 36, 59, 71, 15, 26 } };
            IsToeplitzMatrix(matrix);
        }

        // accepted
        public bool IsToeplitzMatrix(int[,] matrix)
        {
            if (matrix.GetLength(0) == 1 || matrix.GetLength(1) == 1) return true;
            int toeplitzCount = matrix.GetLength(1) - 1;

            // upper right check
            int a, b;
            a = b = 0;
            for (int i = 0; i < toeplitzCount; i++)
            {
                int pivot = matrix[a, b];
                int x, y;
                x = a + 1; y = b + 1;
                while (x < matrix.GetLength(0) && y < matrix.GetLength(1))
                {
                    if (matrix[x, y] != pivot) return false;
                    ++x; ++y;
                }

                b++;
            }

            // lower left check
            toeplitzCount = matrix.GetLength(0) - 2;
            a = 1; b = 0;
            for (int i = 0; i < toeplitzCount; i++)
            {
                int pivot = matrix[a, b];
                int x, y;
                x = a + 1; y = b + 1;
                while (x < matrix.GetLength(0) && y < matrix.GetLength(1))
                {
                    if (matrix[x, y] != pivot) return false;
                    ++x; ++y;
                }

                a++;
            }

            return true;
        }
    }
}
