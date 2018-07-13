using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MyCircularQueue
    {
        List<int> dq;
        int size;
        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            dq = new List<int>();
            size = k;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (!IsFull())
            {
                dq.Add(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (!IsEmpty())
            {
                dq.RemoveAt(0);
                return true;
            }
            else
            {
                return false;
            }
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (!IsEmpty())
            {
                return dq[0];
            }
            else
            {
                return -1;
            }
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (!IsEmpty())
            {
                return dq[dq.Count - 1];
            }
            else
            {
                return -1;
            }
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return dq.Count == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return dq.Count == size;
        }
    }
}
