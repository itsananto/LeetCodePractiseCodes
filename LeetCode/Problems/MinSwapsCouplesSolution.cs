using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MinSwapsCouplesSolution
    {
        public MinSwapsCouplesSolution()
        {
            MinSwapsCouples(new int[] { 0, 2, 1, 3 });
        }

        public int MinSwapsCouples(int[] row)
        {
            var dict = new Dictionary<int, int>();

            int index = 0;
            foreach (var item in row)
            {
                dict[item] = index;
                ++index;
            }

            int numOfSwap = 0;

            int male = 0;
            int female = male + 1;

            for (int i = 0; i < row.Length; i += 2)
            {
                male = i;
                female = male + 1;

                int maleIndex = dict[male];
                int femaleIndex = dict[female];

                int other;
                if (maleIndex % 2 == 1)
                {
                    other = maleIndex - 1;
                    if (other == femaleIndex) continue;
                    else
                    {
                        numOfSwap++;

                        int temp = row[other];
                        row[other] = row[femaleIndex];
                        row[femaleIndex] = temp;

                        dict[female] = other;
                        dict[row[femaleIndex]] = femaleIndex;
                    }
                }
                else
                {
                    other = (femaleIndex % 2 == 1) ? femaleIndex - 1 : femaleIndex + 1;
                    if (other == maleIndex) continue;
                    else
                    {
                        numOfSwap++;

                        int temp = row[other];
                        row[other] = row[maleIndex];
                        row[maleIndex] = temp;

                        dict[male] = other;
                        dict[row[maleIndex]] = maleIndex;
                    }
                }
            }

            return numOfSwap;
        }
    }
}
