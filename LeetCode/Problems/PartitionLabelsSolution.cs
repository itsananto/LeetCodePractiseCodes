using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class PartitionLabelsSolution
    {
        public PartitionLabelsSolution()
        {
            //test cases
            //"ababcbacadefegdehijhklij"
            //"abcdefghijklmnopqrstuvwxyz"
            //"a"
            //"aaaaaaaaaaaaa"
            //"aaakjsdfkssdnflknsdfla"
            //"aabbcc"
            //"abcar"
            PartitionLabels("a");
        }

        //accepted
        public IList<int> PartitionLabels(string S)
        {
            var ret = new List<int>();

            int j = S.LastIndexOf(S[0]);
            int len = 1;
            if (j == 0) ret.Add(len);
            for (int i = 1; i < S.Length; i++)
            {
                if (i < j)
                {
                    len++;
                    int last = S.LastIndexOf(S[i]);
                    if (last > j)
                    {
                        j = last;
                    }
                }
                else if (i == j)
                {
                    len++;
                    ret.Add(len);
                }
                else
                {
                    len = 1;
                    j = S.LastIndexOf(S[i]);
                    if (i == j) ret.Add(len);
                }
            }

            return ret;
        }
    }
}
