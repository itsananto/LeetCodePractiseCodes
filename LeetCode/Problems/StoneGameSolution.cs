using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class StoneGameSolution
    {
        Dictionary<Tuple<int, int>, bool> d = new Dictionary<Tuple<int, int>, bool>();
        public bool StoneGameSimulation(int[] piles, int start, int end, int alex, int lee, bool isTurnForAlex)
        {
            if (start>end)
            {
                return alex > lee;
            }
            else
            {
                bool firstTaken, lastTaken;

                if (d.ContainsKey(new Tuple<int, int>(start + 1, end)))
                {
                    firstTaken = d[new Tuple<int, int>(start + 1, end)];
                }
                else {
                    firstTaken = StoneGameSimulation(piles, start + 1, end, isTurnForAlex ? alex + piles[start] : alex, isTurnForAlex ? lee : lee + piles[start], !isTurnForAlex);
                    d.Add(new Tuple<int, int>(start + 1, end), firstTaken);
                }

                if (firstTaken) return true;

                if (d.ContainsKey(new Tuple<int, int>(start, end - 1)))
                {
                    lastTaken = d[new Tuple<int, int>(start, end - 1)];
                }
                else
                {
                    lastTaken = StoneGameSimulation(piles, start, end - 1, isTurnForAlex ? alex + piles[end] : alex, isTurnForAlex ? lee : lee + piles[end], !isTurnForAlex);
                    d.Add(new Tuple<int, int>(start, end - 1), lastTaken);
                }

                return firstTaken || lastTaken;
            }
        }

        public bool StoneGame(int[] piles)
        {
            d.Clear();
            return StoneGameSimulation(piles, 0, piles.Count() - 1, 0, 0, true);
        }
    }
}
