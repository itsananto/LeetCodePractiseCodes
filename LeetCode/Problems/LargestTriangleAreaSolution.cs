using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class LargestTriangleAreaSolution
    {
        public LargestTriangleAreaSolution()
        {
            int[][] input = new int[5][];
            input[0] = new int[] { 0, 0 };
            input[1] = new int[] { 0, 1 };
            input[2] = new int[] { 1, 0 };
            input[3] = new int[] { 0, 2 };
            input[4] = new int[] { 2, 0 };

            LargestTriangleArea(input);
        }
        public double GetTriangleArea(int[] a, int[] b, int[] c)
        {
            int xa = a[0];
            int xb = b[0];
            int xc = c[0];
            int ya = a[1];
            int yb = b[1];
            int yc = c[1];

            double area = 0.5 * Math.Abs((xa - xc) * (yb - ya) - (xa - xb) * (yc - ya));
            return area;
        }

        public double LargestTriangleArea(int[][] points)
        {
            int length = points.Length;
            double max = 0;
            for (int i = 0; i < length - 2; i++)
            {
                var first = points[i];
                for (int k = i + 1; k < length - 1; k++)
                {
                    var second = points[k];
                    for (int j = i + 2; j < length; j++)
                    {
                        var third = points[j];
                        var area = GetTriangleArea(first, second, third);

                        if (max < area) max = area;
                    }
                }
            }

            return max;
        }
    }
}
