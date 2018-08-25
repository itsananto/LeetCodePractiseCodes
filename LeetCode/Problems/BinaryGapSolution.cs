using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class BinaryGapSolution
    {
        public BinaryGapSolution()
        {
            BinaryGap(5);
        }

        public int BinaryGap(int N)
        {
            int curr = -1;
            int prev = int.MaxValue;

            int distance = 0;

            for (int i = 0; i < 32; i++)
            {
                int mask = 1 << i;
                if((N & mask) >> i == 1)
                {
                    curr = i;
                    distance = Math.Max(distance, curr - prev);

                    prev = curr;
                }
            }

            return distance;
        }
    }
}
