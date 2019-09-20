using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class FindMedianSortedArraysSolution
    {
        public FindMedianSortedArraysSolution()
        {
            FindMedianSortedArrays(new int[] {  }, new int[] { 2, 5 });
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var list = new List<int>();

            int l1 = 0;
            int l2 = 0;

            while (l1 < nums1.Length && l2 < nums2.Length)
            {
                if (nums1[l1] <= nums2[l2])
                {
                    list.Add(nums1[l1]);
                    l1++;
                }
                else
                {
                    list.Add(nums2[l2]);
                    l2++;
                }
            }


            if(l1 == nums1.Length)
            {
                list.AddRange(nums2.Skip(l2));
            }
            else
            {
                list.AddRange(nums1.Skip(l1));
            }

            int n = list.Count;

            if (n % 2 != 0)
                return (double)list[n / 2];

            return (double)(list[(n - 1) / 2] + list[n / 2]) / 2.0;
        }
    }
}
