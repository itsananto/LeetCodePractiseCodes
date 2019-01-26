using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class DeckRevealedIncreasingSolution
    {
        public DeckRevealedIncreasingSolution()
        {
            DeckRevealedIncreasing(new int[] { 17, 13, 11, 2, 3, 5, 7 });
        }

        public int[] DeckRevealedIncreasing(int[] deck)
        {
            List<int> ret = new List<int>();

            var sortedArray = deck.OrderByDescending(x => x);
            foreach (var val in sortedArray)
            {
                if (ret.Count > 1)
                {
                    int last = ret.Last();
                    ret.RemoveAt(ret.Count - 1);
                    ret.Insert(0, last);
                }

                ret.Insert(0, val);
            }

            return ret.ToArray();
        }
    }
}
