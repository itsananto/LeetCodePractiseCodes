using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class CountTripletsSolution
    {
        public CountTripletsSolution()
        {
            CountTriplets(new int[] { 0, 0, 0, 0 });
        }

        public int CountTriplets(int[] A)
        {
            int ret = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] & A[i] & A[i]) == 0) ret++;
                for (int j = i + 1; j < A.Length; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        if ((A[i] & A[j] & A[k]) == 0) ret += 6;
                    }
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {

                    if (i!=j && (A[i] & A[i] & A[j]) == 0)
                    {
                        ret += 3;
                    }
                }
            }

            return ret;
        }
    }
}
