using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class FindAndReplacePatternSolution
    {
        public FindAndReplacePatternSolution()
        {
            FindAndReplacePattern(new string[] { "deq", "mee" }, "abb");
        }

        //words = ["abc","deq","mee","aqq","dkd","ccc"], pattern = "abb"
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var ret = new List<string>();

            foreach (var word in words)
            {
                var temp = new Dictionary<char, char>();
                var v = new HashSet<char>();
                var visited = new bool[26];

                int i = 0;

                bool flag = true;
                foreach (var w in word)
                {
                    if (temp.ContainsKey(w))
                    {
                        if (temp[w] != pattern[i])
                        {
                            flag = false;
                            break;
                        }
                    }
                    else
                    {
                        if(v.Contains(pattern[i]))
                        {
                            flag = false;
                            break;
                        }
                        temp[w] = pattern[i];
                        v.Add(pattern[i]);
                    }

                    ++i;
                }

                if (flag) ret.Add(word);
            }

            return ret;
        }
    }
}
