using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class Automata
    {
        public char character;
        public List<Automata> nextList;
        public bool isFinished;

        public Automata(char ch, bool flag)
        {
            character = ch;
            isFinished = flag;
            nextList = new List<Automata>();
        }
    }

    class IsMatchSolution
    {
        public IsMatchSolution()
        {
            IsMatch("sip", "s*p");
        }

        Automata GenerateAutomata(string p)
        {
            Automata root = new Automata(p.First(), p.Length == 1);
            Automata curr = root;
            for (int i = 1; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    curr.nextList.Add(curr);
                }
                else
                {
                    Automata next = new Automata(p[i], false);
                    curr.nextList.Add(next);
                    curr = next;
                }
            }

            curr.isFinished = true;

            return root;
        }

        bool Match(Automata head, string s, int position)
        {
            if (position < s.Length && (s[position] == head.character || head.character == '.' || head.nextList.Count == 2))
            {
                if (head.isFinished && position == s.Length - 1 && (s[position] == head.character || head.character == '.')) return true;

                if(!(s[position] == head.character || head.character == '.')) return false;

                bool flag = false;
                foreach (var next in head.nextList)
                {
                    flag = flag || Match(next, s, position + 1);
                }

                return flag;
            }
            else
            {
                return false;
            }
        }

        public bool IsMatch(string s, string p)
        {
            var head = GenerateAutomata(p);
            var flag = Match(head, s, 0);
            return flag;
        }

        public bool IsMatch_String(string s, string p)
        {
            if (p.Length == 0 && s.Length == 0) return true;
            else if (p.Length == 0 && s.Length != 0) return false;


            int i = 0;
            bool match = true;
            for (int j = 0; j < p.Length; j++)
            {
                //if (i >= s.Length && p[j] != '*') return false;

                if (p[j] == '.')
                {
                    if (j + 1 < p.Length && p[j + 1] == '*')
                    {
                        return true;
                    }
                    else
                    {
                        ++i;
                    }
                }
                else
                {
                    if (j + 1 < p.Length && p[j + 1] == '*')
                    {
                        while (i < s.Length && s[i] == p[j])
                        {
                            ++i;
                        }
                        ++j;
                    }
                    else
                    {
                        if (i >= s.Length || p[j] != s[i]) return false;
                        ++i;
                    }
                }
            }

            if (i < s.Length) return false;

            return match;
        }
    }
}
