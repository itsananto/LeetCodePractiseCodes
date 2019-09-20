using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class NearestPalindromicSolution
    {
        public int Difference(string n, string p)
        {
            return Math.Abs(int.Parse(n) - int.Parse(p));
        }

        public string NearestPalindromic(string n)
        {
            int mid = n.Length / 2;
            string left = n.Substring(0, mid);
            string leftPlusOne = (int.Parse(left) + 1).ToString();
            string leftMinusOne = (int.Parse(left) - 1).ToString();


            if (n.Length % 2 == 1)
            {
                int min = int.MaxValue;
                int ret = 0;

                if (min < Difference(n, left + mid + left.Reverse())){

                }
            }
            else
            {

            }

            return n;
        }
    }
}
