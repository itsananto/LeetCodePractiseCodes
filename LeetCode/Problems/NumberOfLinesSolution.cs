using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class NumberOfLinesSolution
    {
        public NumberOfLinesSolution()
        {
            //testcases
            //[10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10]
            //"abdfersfwe"
            //[10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10]
            //"abcdefghijklmnopqrstuvwxyz"
            //[4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10]
            //"bbbcccdddaaa"

            NumberOfLines(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "abdfersfwe");
        }

        //accepted
        public int[] NumberOfLines(int[] widths, string S)
        {
            int sum = 0;
            int lines = 1;
            for (int i = 0; i < S.Length; i++)
            {
                sum += widths[S[i] - 'a'];
                if (sum > 100)
                {
                    lines++;
                    sum = 0;
                    sum = widths[S[i] - 'a'];
                }
                else if (sum == 100 && i != S.Length - 1)
                {
                    sum = 0;
                    lines++;
                }
            }

            return new int[] { lines, sum };
        }
    }
}
