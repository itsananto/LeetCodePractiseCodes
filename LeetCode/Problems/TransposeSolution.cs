using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class TransposeSolution
    {
        public TransposeSolution()
        {
            int[][] A = new int[3][];
            A[0] = new int[] { 1, 2, 3 };
            A[1] = new int[] { 1, 2, 3 };
            A[2] = new int[] { 1, 2, 3 };

            Transpose(A);
        }

        public int[][] Transpose(int[][] A)
        {
            int row = A.Length;
            int col = A[0].Length;

            int[][] t = new int[col][];

            for (int i = 0; i < col; i++)
            {
                t[i] = new int[row];
                for (int j = 0;j < row ;j++)
                {
                    t[i][j] = A[j][i];
                }
            }

            return t;
        }
    }
}
