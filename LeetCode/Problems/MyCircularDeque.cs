using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MyCircularDeque
    {
        List<int> dq;
        int size;
        /** Initialize your data structure here. Set the size of the deque to be k. */
        public MyCircularDeque(int k)
        {
            dq = new List<int>();
            size = k;
        }

        /** Adds an item at the front of Deque. Return true if the operation is successful. */
        public bool InsertFront(int value)
        {
            if (!IsFull())
            {
                dq.Insert(0, value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /** Adds an item at the rear of Deque. Return true if the operation is successful. */
        public bool InsertLast(int value)
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

        /** Deletes an item from the front of Deque. Return true if the operation is successful. */
        public bool DeleteFront()
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

        /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
        public bool DeleteLast()
        {
            if (!IsEmpty())
            {
                dq.RemoveAt(dq.Count - 1);
                return true;
            }
            else
            {
                return false;
            }
        }

        /** Get the front item from the deque. */
        public int GetFront()
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

        /** Get the last item from the deque. */
        public int GetRear()
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

        /** Checks whether the circular deque is empty or not. */
        public bool IsEmpty()
        {
            return dq.Count == 0;
        }

        /** Checks whether the circular deque is full or not. */
        public bool IsFull()
        {
            return dq.Count == size;
        }
    }
}
