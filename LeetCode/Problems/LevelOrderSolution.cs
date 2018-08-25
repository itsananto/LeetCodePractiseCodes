using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class LevelOrderSolution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> ret = new List<IList<int>>();

            var current = new Queue<Node>();
            var next = new Queue<Node>();

            if (root != null)
            {
                current.Enqueue(root);
                while (current.Count != 0)
                {
                    ret.Add(current.Select(x=>x.val).ToList());
                    foreach (var node in current)
                    {
                        foreach (var child in node.children)
                        {
                            if(child!=null) next.Enqueue(child);
                        }
                    }

                    current = new Queue<Node>(next);
                    next.Clear();
                }
            }

            return ret;
        }
    }
}
