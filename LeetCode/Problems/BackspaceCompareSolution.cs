using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class BackspaceCompareSolution
    {
        public BackspaceCompareSolution()
        {
            BackspaceCompare("y#fo##f", "y#f#o##f");
        }
        public bool BackspaceCompare(string S, string T)
        {
            Stack<char> ss = new Stack<char>();
            Stack<char> st = new Stack<char>();

            foreach (var item in S)
            {
                if (item == '#' && ss.Count != 0) ss.Pop();
                else if(item!='#') ss.Push(item);
            }

            foreach (var item in T)
            {
                if (item == '#' && st.Count != 0) st.Pop();
                else if (item != '#') st.Push(item);
            }

            if (ss.Count != st.Count) return false;

            while (ss.Count != 0)
            {
                if (ss.Pop() != st.Pop()) return false;
            }

            return true;
        }
    }
}
