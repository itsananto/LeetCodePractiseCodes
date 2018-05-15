using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class CustomSortStringSolution
    {
        public CustomSortStringSolution()
        {
            CustomSortString("kqep", "pekeq");
        }

        //accepted
        public string CustomSortString(string S, string T)
        {
            int[] alpha = new int[26];
            foreach (var ch in S)
            {
                alpha[ch - 'a']++;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var ch in T)
            {
                if (alpha[ch - 'a'] >= 1)
                {
                    alpha[ch - 'a']++;
                }
                else
                {
                    sb.Append(ch);
                }
            }

            foreach (var ch in S)
            {
                if (alpha[ch - 'a'] >= 2)
                {
                    sb.Append(ch, alpha[ch - 'a']-1);
                }
            }

            return sb.ToString();
        }
    }
}
