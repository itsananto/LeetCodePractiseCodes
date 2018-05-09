using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructures
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public ListNode(int[] arr)
        {
            ListNode head = this;
            head.val = arr[0];

            foreach (var item in arr.Skip(1))
            {
                head.next = new ListNode(item);
                head = head.next;
            }
        }
    }
}
