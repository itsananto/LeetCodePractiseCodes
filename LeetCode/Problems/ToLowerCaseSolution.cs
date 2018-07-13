using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class ToLowerCaseSolution
    {
        public string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z') sb.Append((char)(ch - 'A' + 'a'));
                else sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}
