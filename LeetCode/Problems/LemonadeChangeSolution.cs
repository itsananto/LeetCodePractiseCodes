using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class LemonadeChangeSolution
    {
        public bool LemonadeChange(int[] bills)
        {
            int cash = 0;

            foreach (int c in bills)
            {
                int toRet = c - 5;
                if (cash < toRet) return false;

                cash += 5;
            }

            return true;
        }
    }
}
