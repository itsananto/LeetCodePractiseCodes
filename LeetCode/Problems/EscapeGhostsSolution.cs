using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class EscapeGhostsSolution
    {
        public EscapeGhostsSolution()
        {
            var inp = new int[2][];
            inp[0] = new int[] { 1, 0 };
            inp[1] = new int[] { 0, 3 };
            var target = new int[] { 0, 1 };

            EscapeGhosts(inp, target);
        }
        public int CardinalDistance(int[] position, int[] target)
        {
            return Math.Abs(position[1] - target[1]) + Math.Abs(position[0] - target[0]);
        }
        public bool EscapeGhosts(int[][] ghosts, int[] target)
        {
            int min = int.MaxValue;
            foreach (var item in ghosts)
            {
                int d = CardinalDistance(item, target);
                if (d < min) min = d;
            }

            int dis = CardinalDistance(new int[] { 0, 0 }, target);

            return dis < min;
        }
    }
}
