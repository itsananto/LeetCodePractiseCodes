using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MostCommonWordSolution
    {
        public MostCommonWordSolution()
        {
            MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
        }
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var splitArr = paragraph.Split(new char[] { ' ', '!', '?', '\'', ',', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var d = banned.ToDictionary(x=>x, y=>true);

            var rd = new Dictionary<string, int>();
            foreach (var item in splitArr)
            {
                if (!d.ContainsKey(item.ToLower()))
                {
                    if (rd.ContainsKey(item.ToLower()))
                    {
                        rd[item.ToLower()]++;
                    } else
                    {
                        rd[item.ToLower()] = 1;
                    }
                }
            }


            return rd.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }
    }
}
