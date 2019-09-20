using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MinDeletionSizeSolution
    {
        public MinDeletionSizeSolution()
        {
            MinDeletionSize(new string[] { "abbba" });
            LIS(new int[] { 1, 2, 2, 2, 1 });
        }
        public void LIS(int[] lis)
        {
            int[] dp = new int[lis.Length];

            dp[0] = 1;
            for (int i = 1; i < lis.Length; i++)
            {
                int max = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (lis[i] >= lis[j] && max <= dp[j]) // If values are same, still considering its a increasing sequence
                        max = dp[j];
                }

                dp[i] = max + 1;
            }
        }

        public int MinDeletionSize(string[] A)
        {
            int[] dp = new int[A[0].Length];

            dp[0] = 1;
            for (int i = 1; i < A[0].Length; i++)
            {
                int max = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    bool flag = true;
                    for (int k = 0; k < A.Length; k++)
                    {
                        flag &= A[k][i] >= A[k][j];
                    }

                    if (flag && max <= dp[j])
                        max = dp[j];
                }

                dp[i] = max + 1;
            }

            return A[0].Length - dp.Max();
        }
    }
}
