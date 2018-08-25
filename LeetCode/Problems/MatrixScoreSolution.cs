using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MatrixScoreSolution
    {
        public MatrixScoreSolution()
        {
            int[][] A = new int[3][];
            A[0] = new int[] { 0, 1, 1 };
            A[1] = new int[] { 1, 1, 1 };
            A[2] = new int[] { 0, 1, 0 };

            MatrixScore(A);
        }

        public bool BinarytArrayToIntCompare(int[] arr, bool flag)
        {
            int val = 0;
            int revVal = 0;
            int mult = 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                val += arr[i] * mult;
                revVal += (1 - arr[i]) * mult;
               if(flag) mult *= 2;
            }

            return revVal>val;
        }

        public bool UpdateRow(int[][] A)
        {
            bool flag = false;
            for (int i = 0; i < A.Length; i++)
            {
                if (BinarytArrayToIntCompare(A[i], true))
                {
                    flag = true;
                    for (int j = 0; j < A[i].Length; j++)
                    {
                        A[i][j] = 1 - A[i][j];
                    }
                }
            }

            return flag;
        }

        public bool UpdateCol(int[][] A)
        {
            bool flag = false;
            for (int i = 0; i < A[0].Length; i++)
            {
                var arr = new int[A.Length];
                for (int j = 0; j < A.Length; j++)
                {
                    arr[j] = A[j][i];
                }
                if (BinarytArrayToIntCompare(arr, false))
                {
                    flag = true;
                    for (int j = 0; j < A.Length; j++)
                    {
                        A[j][i] = 1 - A[j][i];
                    }
                }
            }

            return flag;
        }

        public void print(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[0].Length; j++)
                {
                    Console.Write(A[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
        }

        public int MatrixScore(int[][] A)
        {
            int sum = 0;

            bool first = true;
            bool second = true;

            print(A);

            while (first && second)
            {
                first = UpdateRow(A);
                print(A);
                second = UpdateCol(A);
                print(A);
            }

            int mult = 1;

            for (int i = 0; i < A.Length; i++)
            {
                mult = 1;
                for (int j = A[i].Length - 1; j>= 0; j--)
                {
                    sum += A[i][j] * mult;
                    mult *= 2;
                }
            }
            

            return sum;
        }
    }
}
