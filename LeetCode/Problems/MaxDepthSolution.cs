using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MaxDepthSolution
    {
        public int MaxDepth(Node root)
        {
            if (root == null) return 0;
            else
            {
                int max = 0;
                foreach (var child in root.children)
                {
                    max = Math.Max(max, MaxDepth(child));
                }

                return 1 + max;
            }
        }
    }
}
