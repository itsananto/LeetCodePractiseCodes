using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MaxChunksToSortedSolution
    {
        public MaxChunksToSortedSolution()
        {
            MaxChunksToSorted(new int[] { 0, 1, 2, 3, 9, 8, 7, 6, 5, 4 });
        }

        public bool isSameArrayEmelents(HashSet<int> arr, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (!arr.Contains(i)) return false;
            }

            return true;
        }

        public int MaxChunksToSorted(int[] arr)
        {
            int chunks = 0;
            var hash = new HashSet<int>();

            int start = 0;
            int end = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                hash.Add(arr[i]);
                if (isSameArrayEmelents(hash, start, end))
                {
                    start = end = i + 1;
                    chunks++;
                    hash.Clear();
                }
                else
                {
                    end++;
                }
            }

            return chunks;
        }
    }
}
