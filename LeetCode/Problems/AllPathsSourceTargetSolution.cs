using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class AllPathsSourceTargetSolution
    {
        IList<IList<int>> ret = new List<IList<int>>();

        public AllPathsSourceTargetSolution()
        {
            int[][] input = new int[4][];
            input[0] = new int[] { 1,2 };
            input[1] = new int[] { 3};
            input[2] = new int[] { 3 };
            input[3] = new int[] { };

            AllPathsSourceTarget(input);
        }

        public void Travarse(int[][] graph, int source, int destination, List<int> path)
        {
            if (source == destination)
            {
                path.Add(destination);
                ret.Add(path);
            }
            else
            {
                foreach (var val in graph[source])
                {
                    List<int> p = new List<int>(path);
                    p.Add(source);
                    Travarse(graph, val, destination, p);
                }
            }
        }

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            int destination = graph.GetLength(0) - 1;
            var list = new List<int>();
            Travarse(graph, 0, destination, list);
            return ret;
        }
    }
}
