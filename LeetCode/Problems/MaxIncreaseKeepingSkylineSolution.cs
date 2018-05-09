using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MaxIncreaseKeepingSkylineSolution
    {
        public MaxIncreaseKeepingSkylineSolution()
        {
            int[][] input = new int[4][];
            input[0] = new int[] { 3, 0, 8, 4 };
            input[1] = new int[] { 2, 4, 5, 7 };
            input[2] = new int[] { 9, 2, 6, 3 };
            input[3] = new int[] { 0, 3, 1, 0 };

            MaxIncreaseKeepingSkyline(input);
        }

        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int row = grid.GetLength(0);
            int col = grid[0].GetLength(0);

            int[] rowWiseMax = new int[row];
            int[] colWiseMax = new int[col];

            for (int i = 0; i < row; i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] > max) max = grid[i][j];
                }
                rowWiseMax[i] = max;
            }

            for (int i = 0; i < col; i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < row; j++)
                {
                    if (grid[j][i] > max) max = grid[j][i];
                }
                colWiseMax[i] = max;
            }

            int ret = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    ret += Math.Min(rowWiseMax[i], colWiseMax[j]) - grid[i][j];
                }
            }

            return ret;
        }
    }
}
