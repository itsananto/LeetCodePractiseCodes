using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class ShortestToCharSolution
    {
        public ShortestToCharSolution()
        {
            //testcases
            //"loveleetcode"
            //"e"
            //"eeeeee"
            //"e"
            //"e"
            //"e"
            //"vsdadfsdvsdvsdve"
            //"e"
            //"'esdfsdcsvse"
            //"e"
            //"ewewewewewewewe"
            //"e"
            //"ecvbcdsfsdbsdfsdfsf"
            //"e"
            //"qwesdfsvs"
            //"e"
            ShortestToChar("ecvbcdsfsdbsdfsdfsf", 'e');
        }

        //accepted
        public int[] ShortestToChar(string S, char C)
        {
            int prev = int.MaxValue;
            int next = int.MinValue;

            int[] ret = new int[S.Length];

            for (int i = 0; i < S.Length; i++)
            {
                if (i != 0 && next < 0) prev = S.LastIndexOf(C);
                else if (i > next)
                {
                    prev = next;
                    next = S.IndexOf(C, next < 0 ? 0 : (next + 1));
                }

                if (prev < 0) ret[i] = next - i;
                else if (next < 0) ret[i] = i - prev;
                else ret[i] = Math.Min(i - prev, next - i);
            }

            return ret;
        }
    }
}
