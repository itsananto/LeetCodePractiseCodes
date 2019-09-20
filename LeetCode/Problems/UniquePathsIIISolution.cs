using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class UniquePathsIIISolution
    {
        public UniquePathsIIISolution()
        {
            int[][] grid = new int[3][];
            grid[0] = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            grid[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            grid[2] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, -1 };

            UniquePathsIII(grid);
        }

        public int Search(int[][] grid, bool[,] visited, int row, int col)
        {
            if (grid[row][col] == 2)
            {

                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        if (grid[i][j] == 0 && visited[i,j] == false) return 0;
                    }
                }

                return 1;
            }
            else if (grid[row][col] == -1) return 0;
            else if (visited[row, col] == true) return 0;
            else
            {
                visited[row, col] = true;
                int posibilities = 0;

                if (row != grid.Length - 1)
                {
                    posibilities += Search(grid, (bool[,])visited.Clone(), row + 1, col);
                }
                if (col != grid[0].Length - 1)
                {
                    posibilities += Search(grid, (bool[,])visited.Clone(), row, col + 1);
                }
                if (col != 0)
                {
                    posibilities += Search(grid, (bool[,])visited.Clone(), row, col - 1);
                }
                if (row != 0)
                {
                    posibilities += Search(grid, (bool[,])visited.Clone(), row - 1, col);
                }


                return posibilities;
            }
        }

        public int UniquePathsIII(int[][] grid)
        {

            bool[,] visited = new bool[grid.Length, grid[0].Length];

            int paths = 0; ;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        paths = Search(grid, visited, i, j);
                        return paths;
                    }
                }
            }

            return paths;
        }
    }
}
