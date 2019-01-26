using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class Regex
    {
        public char Character { get; set; }
        public Regex Next { get; set; }
        public bool IsFinished { get; set; }
        public bool HasSelfLoop { get; set; }

        public Regex(Regex obj)
        {
            Character = obj.Character;
            Next = obj.Next;
            IsFinished = obj.IsFinished;
            HasSelfLoop = obj.HasSelfLoop;
        }

        public Regex(char ch, bool flag)
        {
            Character = ch;
            IsFinished = flag;
        }
    }

    class IsMatchSolution2
    {
        public IsMatchSolution2()
        {

            Debug.Assert(IsMatch("aaa", "a*") == true);
            Debug.Assert(IsMatch("aaa", "a*b") == false);
            Debug.Assert(IsMatch("aaa", "a*a") == true);
            Debug.Assert(IsMatch("aaa", "a*b*c") == false);
            Debug.Assert(IsMatch("aaa", "aa*a") == true);
            Debug.Assert(IsMatch("aaa", "aaa") == true);
            Debug.Assert(IsMatch("aaa", "aa") == false);
            Debug.Assert(IsMatch("aaa", "aa*") == true);
            Debug.Assert(IsMatch("aaa", "aa*a*") == true);
            Debug.Assert(IsMatch("aa", "a") == false);
            Debug.Assert(IsMatch("aab", "c*a*b") == true);
            Debug.Assert(IsMatch("aaa", "aaaa") == false);
            Debug.Assert(IsMatch("aaa", "a") == false);

            Debug.Assert(IsMatch("mississippi", "mis*is*p*.") == false);
            Debug.Assert(IsMatch("abc", "b.*") == false);
            Debug.Assert(IsMatch("abc", "ab.*") == true);
            Debug.Assert(IsMatch("abc", "a.c") == true);

            Debug.Assert(IsMatch("ab", "a*") == false);
            Debug.Assert(IsMatch("ab", ".*") == true);
            Debug.Assert(IsMatch("ab", ".*c") == false);

            Debug.Assert(IsMatch("aaa", "a*b*a") == true);

            Debug.Assert(IsMatch("abcde", "a....*") == true);

            Debug.Assert(IsMatch("", "a") == false);
            Debug.Assert(IsMatch("", ".*") == true);
            Debug.Assert(IsMatch("a", "") == false);
            Debug.Assert(IsMatch("abcd", "d*") == false);


            Debug.Assert(IsMatch("abcdef", "a.*") == true);
            Debug.Assert(IsMatch("abcde", "a...*") == true);
            Debug.Assert(IsMatch("aaa", "a*b*") == true);

            Debug.Assert(IsMatch("ba", ".*a*a") == true);
            Debug.Assert(IsMatch("bbbba", ".*a*a") == true);

        }

        Regex GenerateAutomata(string p)
        {
            Regex root = new Regex(p.First(), p.Length == 1);
            Regex curr = root;
            for (int i = 1; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    curr.HasSelfLoop = true;
                }
                else
                {
                    Regex next = new Regex(p[i], false);
                    curr.Next = next;
                    curr = next;
                }
            }

            curr.IsFinished = true;

            return root;
        }

        bool Match(Regex head, string str, int position)
        {
            if (head == null) return false;
            if (position == str.Length - 1)
            {
                if (head.IsFinished && (head.Character == str[position] || head.Character == '.')) return true;
                else if (head.Character != str[position] && head.Next == null) return false;
            }

            if (position <= str.Length - 1 && str[position] == head.Character)
            {

                if (position == str.Length - 1 && head.Next.IsFinished && head.Next.HasSelfLoop) return true;

                if (head.HasSelfLoop)
                {
                    bool a = Match(head, str, position + 1);
                    bool b = Match(head.Next, str, position + 1);
                    return a || b;
                }
                else
                {
                    return Match(head.Next, str, position + 1);
                }
            }
            else if (position <= str.Length - 1 && head.Character == '.')
            {
                if (head.HasSelfLoop)
                {
                    return Match(head, str, position + 1) || Match(head.Next, str, position + 1);
                }
                else
                {
                    return Match(head.Next, str, position + 1);
                }
            }
            else
            {
                if (head.HasSelfLoop)
                {
                    if (head.IsFinished && position == str.Length - 1) return true;
                    return Match(head.Next, str, position);
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsMatch(string s, string p)
        {
            if (p == "") return s == "";
            if (p == ".*") return true;
            var head = GenerateAutomata(p);
            var flag = Match(head, s, 0);
            return flag;
        }
    }
}
