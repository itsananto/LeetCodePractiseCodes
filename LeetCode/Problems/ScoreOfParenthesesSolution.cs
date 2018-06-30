using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class ScoreOfParenthesesSolution
    {
        public ScoreOfParenthesesSolution()
        {
            ScoreOfParentheses("()(())()");
            ScoreOfParentheses("()()()(())()()()");
        }

        public int ScoreOfParentheses(string S)
        {
            if (S == "") return 0;
            else if (S == "()") return 1;
            else
            {
                if (S.StartsWith("()")) return 1 + ScoreOfParentheses(S.Substring(2));
                else
                {
                    var stack = new Stack<char>();
                    stack.Push('(');
                    stack.Push('(');

                    int i;
                    for (i = 2; i < S.Length; i++)
                    {
                        if (S[i] == '(') stack.Push('(');
                        else stack.Pop();

                        if (stack.Count == 0)
                        {
                            break;
                        }
                    }

                    return 2 * ScoreOfParentheses(S.Substring(1, i-1)) + ScoreOfParentheses(S.Substring(i + 1));
                }
            }

        }
    }
}
