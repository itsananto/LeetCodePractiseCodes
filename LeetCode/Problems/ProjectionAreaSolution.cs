using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class ProjectionAreaSolution
    {
        public ProjectionAreaSolution()
        {
            int[][] input = new int[2][];

            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            ProjectionArea(input);
        }

        public int ProjectionArea(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;

            int xAxis = 0;

            int yAxis = 0;
            for (int i = 0; i < row; i++)
            {
                yAxis += grid[i].Max();
            }

            int zAxis = 0;
            for (int i = 0; i < row; i++)
            {
                int max = -1;
                for (int j = 0; j < col; j++)
                {
                    xAxis += grid[i][j] > 0 ? 1 : 0;
                    if (max < grid[j][i]) max = grid[j][i];
                }

                zAxis += max;
            }

            return xAxis + yAxis + zAxis;
        }
    }
}
