using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helpers
{
    public static class ExtensionHelper
    {
        public static T[][] ToJagged<T>(this T[,] array)
        {
            int height = array.GetLength(0), width = array.GetLength(1);
            T[][] jagged = new T[height][];

            for (int i = 0; i < height; i++)
            {
                T[] row = new T[width];
                for (int j = 0; j < width; j++)
                {
                    row[j] = array[i, j];
                }
                jagged[i] = row;
            }
            return jagged;
        }

        public static T[,] ToRectangular<T>(this T[][] array)
        {
            int height = array.Length, width = array[0].Length;
            T[,] rect = new T[height, width];
            for (int i = 0; i < height; i++)
            {
                T[] row = array[i];
                for (int j = 0; j < width; j++)
                {
                    rect[i, j] = row[j];
                }
            }
            return rect;
        }
    }
}
