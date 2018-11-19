using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class IsMatchSolution
    {
        public IsMatchSolution()
        {
            IsMatch("aab", "c*a*b");
        }

        public bool IsMatch(string s, string p)
        {
            int i = 0;
            bool match = true;
            for (int j = 0; j < p.Length; j++)
            {
                if (i >= s.Length && p[j] != '*') return false;

                if (p[j] == '.')
                {
                    ++i;
                }
                else
                {
                    if (p[j] == '*')
                    {
                        if (j == 0) return false;
                        char prev = p[j - 1];

                        while (i < s.Length && s[i] == prev)
                        {
                            ++i;
                        }

                    }
                    else
                    {
                        if (p[j] != s[i]) return false;
                        ++i;
                    }
                }

                if (i < s.Length) return false;

                return match;
            }
        }
    }
