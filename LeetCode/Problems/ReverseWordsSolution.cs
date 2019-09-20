using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LeetCode.Problems
{
    class ReverseWordsSolution
    {
        public string ReverseWords(string s)
        {
            s = s.Trim();
            var words = Regex.Split(s, @"\s+");
            return words.Reverse().Aggregate((i, j) => i + " " + j);
        }
    }
}
