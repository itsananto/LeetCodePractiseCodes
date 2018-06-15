using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class FloodFillSolution
    {
        public void DFS(int[,] image, int sr, int sc, int prevColor, int newColor)
        {
            image[sr, sc] = newColor;
            int row = image.GetLength(0);
            int col = image.GetLength(1);

            if (sr != 0 && image[sr - 1, sc] == prevColor)
            {
                DFS(image, sr - 1, sc, prevColor, newColor);
            }
            if (sc != 0 && image[sr, sc - 1] == prevColor)
            {
                DFS(image, sr, sc - 1, prevColor, newColor);
            }
            if (sr != row - 1 && image[sr + 1, sc] == prevColor)
            {
                DFS(image, sr + 1, sc, prevColor, newColor);
            }
            if (sc != col - 1 && image[sr, sc + 1] == prevColor)
            {
                DFS(image, sr, sc + 1, prevColor, newColor);
            }
        }

        public int[,] FloodFill(int[,] image, int sr, int sc, int newColor)
        {
            if (image[sr, sc] != newColor)
                DFS(image, sr, sc, image[sr, sc], newColor);
            return image;
        }
    }
}
