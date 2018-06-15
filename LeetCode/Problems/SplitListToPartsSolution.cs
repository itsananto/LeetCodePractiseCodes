using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class SplitListToPartsSolution
    {
        public SplitListToPartsSolution()
        {
            SplitListToParts(null, 1);
        }

        public ListNode[] SplitListToParts(ListNode root, int k)
        {
            ListNode head = root;
            int length = 0;
            while (head != null)
            {
                head = head.next;
                length++;
            }

            ListNode[] ret = new ListNode[k];

            if (length % k == 0)
            {
                for (int i = 0; i < k; i++)
                {
                    ret[i] = root;
                    int subLength = length / k;
                    ListNode prev = null;
                    while (subLength > 0)
                    {
                        prev = root;
                        root = root.next;
                        subLength--;
                    }

                    if (prev != null)
                        prev.next = null;
                }
            }
            else
            {
                int div = k;
                for (int i = 0; i < k; i++)
                {
                    ret[i] = root;
                    int subLength = length % div == 0 ? length / div : (int)Math.Ceiling((double)length / div);
                    div--;
                    length -= subLength;

                    ListNode prev = null;
                    while (subLength > 0)
                    {
                        prev = root;
                        root = root.next;
                        subLength--;
                    }

                    if (prev != null)
                        prev.next = null;
                }
            }

            return ret;
        }
    }
}
