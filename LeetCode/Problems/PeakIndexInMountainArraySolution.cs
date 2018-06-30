using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class PeakIndexInMountainArraySolution
    {
        public PeakIndexInMountainArraySolution()
        {
            PeakIndexInMountainArray(new int[] { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19});
        }

        public int BinarySearch(int[] A, int start, int end)
        {
            int mid = (start + end) / 2;
            if (A[mid - 1] < A[mid] && A[mid] < A[mid + 1]) return BinarySearch(A, mid + 1, end);
            else if (A[mid - 1] > A[mid] && A[mid] > A[mid + 1]) return BinarySearch(A, start, mid-1);
            else return mid;

        }

        public int PeakIndexInMountainArray(int[] A)
        {
            return BinarySearch(A, 0, A.Length - 1);
        }
    }
}
