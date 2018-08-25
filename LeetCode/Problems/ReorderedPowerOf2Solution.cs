using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class ReorderedPowerOf2Solution
    {
        public ReorderedPowerOf2Solution()
        {
            ReorderedPowerOf2(24);
        }

        public bool ReorderedPowerOf2(int N)
        {
            List<string> hash = new List<string>();
            int power = 1;
            hash.Add(power.ToString());
            while (power < 1000000000)
            {
                power *= 2;
                hash.Add(power.ToString());
            }

            var check = N.ToString();
            foreach (var item in hash.Where(x=>x.Length == check.Length))
            {
                if (string.Concat(item.OrderBy(x => x)) == string.Concat(check.OrderBy(x => x))) return true;
            }

            return false;
        }
    }
}
