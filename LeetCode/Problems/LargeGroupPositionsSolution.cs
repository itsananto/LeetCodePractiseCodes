using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class LargeGroupPositionsSolution
    {
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            char prev = S[0];
            int start, end;

            start = end = 0;
            var ret = new List<IList<int>>();
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == prev)
                {
                    end++;
                }
                else
                {
                    if (end - start >= 2) ret.Add(new List<int>() { start, end });
                    start = end = i;
                }

                prev = S[i];
            }

            if (end - start >= 2) ret.Add(new List<int>() { start, end });

            return ret;
        }
    }
}
