using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MiddleNodeSolution
    {
        public MiddleNodeSolution()
        {
            var head = new ListNode(new int[] { 1, 2, 3, 4, 5, 6 });
            MiddleNode(head);
        }

        public ListNode MiddleNode(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            int count = 0;
            while (head != null)
            {
                stack.Push(head);
                head = head.next;
                count++;
            }

            for (int i = count; i > count / 2 + 1; i--)
            {
                stack.Pop();
            }

            return stack.Peek();
        }
    }
}
