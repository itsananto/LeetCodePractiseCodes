using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class RotateStringSolution
    {
        public bool RotateString(string A, string B)
        {
            if (A.Equals(B)) return true;
            int len = A.Length;

            for (int i = 0; i < len; i++)
            {
                if (A.Equals(B)) return true;
                StringBuilder sb = new StringBuilder(A.Substring(1));
                sb.Append(A[0]);

                A = sb.ToString();
            }

            return false;
        }
    }
}
