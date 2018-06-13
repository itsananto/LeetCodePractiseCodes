using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MyCalendarThreeSolution
    {
        public MyCalendarThreeSolution()
        {
            MyCalendarThree obj = new MyCalendarThree();
            int k;

            k = obj.Book(10, 20); // returns 1
            k = obj.Book(50, 60); // returns 1
            k = obj.Book(10, 40); // returns 2
            k = obj.Book(5, 15); // returns 3
            k = obj.Book(5, 10); // returns 3
            k = obj.Book(25, 55); // returns 3
        }
    }

    //TLE
    class MyCalendarThree_2
    {
        byte[] arr;
        int max = 0;
        public MyCalendarThree_2()
        {
            arr = new byte[1000000001];
        }

        public int Book(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                arr[i]++;
                if (arr[i] > max) max = arr[i];
            }

            return max;
        }
    }

    //Accepted
    class MyCalendarThree
    {
        int max = 0;
        SegmentTree st;
        public MyCalendarThree()
        {
            st = new SegmentTree(0, 0, 119);
        }

        public int Book(int start, int end)
        {
            int ret = st.UpdateRange(start, end - 1);
            if (ret > max) max = ret;
            return max;
        }
    }

    class SegmentTree
    {
        public int val;
        public int leftValue;
        public int rightValue;
        public SegmentTree left;
        public SegmentTree right;

        public SegmentTree(int v, int l, int r)
        {
            val = v;
            leftValue = l;
            rightValue = r;
        }

        public int UpdateRange(int start, int end)
        {
            if (start == leftValue && end == rightValue)
            {
                int ret = Propagate(this);
                return Math.Max(ret, val);
            }

            int mid = (leftValue + rightValue) / 2;

            if (end <= mid)
            {
                if (left == null) this.left = new SegmentTree(val, leftValue, mid);
                return Math.Max(val, this.left.UpdateRange(start, end));
            }
            else if (start <= mid && mid < end)
            {
                if (left == null) this.left = new SegmentTree(val, leftValue, mid);
                if (right == null) this.right = new SegmentTree(val, mid + 1, rightValue);
                var ret = Math.Max(this.left.UpdateRange(start, mid), this.right.UpdateRange(mid + 1, end));
                return Math.Max(val, ret);
            }
            else
            {
                if (right == null) this.right = new SegmentTree(val, mid + 1, rightValue);
                return Math.Max(val, this.right.UpdateRange(start, end));
            }
        }

        public int Propagate(SegmentTree subRoot)
        {
            if (subRoot != null)
            {
                subRoot.val++;
                int l = Propagate(subRoot.left);
                int r = Propagate(subRoot.right);
                return Math.Max(subRoot.val, Math.Max(l, r));
            }
            else
            {
                return 0;
            }
        }
    }
}
