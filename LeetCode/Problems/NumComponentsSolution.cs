using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class NumComponentsSolution
    {
        public NumComponentsSolution()
        {
            NumComponents(new ListNode(new int[] { 0, 1, 2, 3 }), new int[] { 0, 1, 3 });
        }

        public int NumComponents(ListNode head, int[] G)
        {
            var dictionary = G.Select((v, i) => new { v, i }).ToDictionary(x => x.v, x => true);

            int components = 0;

            bool prev = false, curr;

            while (head != null)
            {
                curr = dictionary.ContainsKey(head.val);
                if (!prev && curr) components++;

                head = head.next;
                prev = curr;
            }

            return components;
        }
    }
}
