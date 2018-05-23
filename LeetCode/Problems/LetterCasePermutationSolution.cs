using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class LetterCasePermutationSolution
    {
        public LetterCasePermutationSolution()
        {
            LetterCasePermutation("a1b2c3d456ef6akloip698776567");
        }
        List<string> ret = new List<string>();

        public void LetterCasePermutation(string S, int index)
        {
            if (index >= S.Length)
            {
                ret.Add(S);
            }
            else
            {
                bool flag = true;
                for (int i = index; i < S.Length; i++)
                {
                    if (char.IsLetter(S[i]))
                    {
                        flag = false;
                        StringBuilder SS = new StringBuilder(S);

                        if (char.IsUpper(S[i]))
                        {
                            SS[i] = (char)(S[i]+32); 
                        }
                        else
                        {
                            SS[i] = (char)(S[i] - 32);
                        }

                        LetterCasePermutation(S, i + 1);
                        LetterCasePermutation(SS.ToString(), i + 1);
                        break;
                    }
                }

                if(flag)
                    ret.Add(S);
            }
        }

        public IList<string> LetterCasePermutation(string S)
        {
            LetterCasePermutation(S, 0);
            return ret;
        }
    }
}
