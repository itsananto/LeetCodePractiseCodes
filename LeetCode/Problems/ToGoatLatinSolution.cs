using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class ToGoatLatinSolution
    {
        public string ToGoatLatin(string S)
        {
            var split = S.Split(new char[] { ' ' }, StringSplitOptions.None);

            StringBuilder sb = new StringBuilder();

            int index = 1;
            foreach (var word in split)
            {
                if ("aeiouAEIOU".IndexOf(word[0]) >= 0)
                {
                    sb.Append(word);

                }
                else
                {
                    sb.Append(word.Substring(1));
                    sb.Append(word[0]);
                }

                sb.Append("ma");
                sb.Append('a', index);
                if(index < split.Length) sb.Append(' ');
                index++;
            }

            return sb.ToString();
        }
    }
}
