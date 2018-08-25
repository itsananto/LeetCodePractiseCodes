using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class DecodeAtIndexSolution
    {
        public DecodeAtIndexSolution()
        {
            DecodeAtIndex("y959q969u3hb22odq595", 222280369);
        }

        public string DecodeAtIndex(string S, int K)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var ch in S)
            {
                if (char.IsLetter(ch))
                {
                    sb.Append(ch);
                    if (sb.Length >= K) break;
                }
                else
                {
                    int repeat = (ch - '0') - 1;
                    string toRepeat = sb.ToString();

                    for (int i = 0; i < repeat; i++)
                    {
                        foreach (var c in toRepeat)
                        {
                            sb.Append(c);
                            if (sb.Length >= K) break;
                        }
                    }
                }

                if (sb.Length >= K) break;
            }

            return sb[K - 1].ToString();
        }
    }
}
