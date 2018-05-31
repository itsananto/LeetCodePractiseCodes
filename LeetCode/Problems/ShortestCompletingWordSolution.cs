using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class ShortestCompletingWordSolution
    {
        public ShortestCompletingWordSolution()
        {
            ShortestCompletingWord("1s3 PSt", new string[] { "step", "steps", "stripe", "stepple" });
        }

        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var global = new Dictionary<char, int>();
            int actualLength = 0;
            
            foreach (var ch in licensePlate)
            {
                char c = char.ToLower(ch);
                if (char.IsLetter(c))
                {
                    actualLength++;
                    if (global.ContainsKey(c)) global[c]++;
                    else global[c] = 1;
                }
            }

            words = words.OrderBy(x => x.Length).ToArray();
             
            foreach (var word in words)
            {
                if (actualLength > word.Length) continue;

                var local = new Dictionary<char, int>();
                foreach (var c in word)
                {
                    if (local.ContainsKey(c)) local[c]++;
                    else local[c] = 1;
                }

                bool flag = true;
                foreach (var item in global)
                {
                    if(!(local.ContainsKey(item.Key) && local[item.Key] >= item.Value))
                    {
                        flag = false; 
                        break;
                    }
                }

                if (flag) return word;
            }

            return "";
        }
    }
}
