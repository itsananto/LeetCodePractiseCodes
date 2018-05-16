using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class CountPrimeSetBitsSolution
    {
        public CountPrimeSetBitsSolution()
        {
            CountPrimeSetBits_2(1, 10000000);
        }

        // accepted
        public int CountPrimeSetBits(int L, int R)
        {
            var prime = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };
            int ret = 0;
            for (int i = L; i <= R; i++)
            {
                int temp = i;
                int setBits = 1;

                while ((temp & (temp - 1)) != 0)
                {
                    setBits++;
                    temp = temp & (temp - 1);
                }

                if (prime.Where(x => x == setBits).Count() == 1) ret++;
            }

            return ret;
        }

        // accepted
        public int CountPrimeSetBits_2(int L, int R)
        {
            var prime = new int[] { 0, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0 };
            int ret = 0;
            for (int i = L; i <= R; i++)
            {
                int temp = i;
                int setBits = 1;

                while ((temp & (temp - 1)) != 0)
                {
                    setBits++;
                    temp = temp & (temp - 1);
                }

                if (prime[setBits] == 1) ret++;
            }

            return ret;
        }
    }
}
