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
            int five = 0;
            int ten = 0;

            foreach (int c in bills)
            {

                if (c == 5) five++;
                else if (c == 10)
                {
                    ten++;
                    if (five >=1)
                    {
                        five--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if(five>=1 && ten >= 1)
                    {
                        five--;
                        ten--;
                    }
                    else if(five>=3)
                    {
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
