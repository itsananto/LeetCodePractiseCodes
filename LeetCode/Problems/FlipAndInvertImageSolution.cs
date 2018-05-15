using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class FlipAndInvertImageSolution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int j = 0;
                int k = A[i].Length - 1;

                while (j <= k)
                {
                    int temp = A[i][j];
                    A[i][j] = A[i][k];
                    A[i][k] = temp;

                    
                    A[i][j] = 1 - A[i][j];
                    if (j != k) A[i][k] = 1 - A[i][k];

                    j++;
                    k--;
                }
            }

            return A;
        }
    }
}
