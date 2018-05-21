using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class UniqueMorseRepresentationsSolution
    {
        string[] input = new string[] { "gin", "zen", "gig", "msg" };

        public UniqueMorseRepresentationsSolution()
        {
            int output = UniqueMorseRepresentations(input);
        }

        //accepted
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morseCodeArray = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            Dictionary<string, int> hash = new Dictionary<string, int>();

            foreach (string word in words)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in word)
                {
                    sb.Append(morseCodeArray[c - 'a']);
                }
                string key = sb.ToString();

                hash[key] = 1;

            }

            return hash.Count;
        }
    }
}
