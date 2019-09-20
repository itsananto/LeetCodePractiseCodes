using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MyPair
    {
        public int Item1 { get; set; }
        public bool Item2 { get; set; }

        public MyPair(int a, bool b)
        {
            Item1 = a;
            Item2 = b;
        }
    }

    class FreqStack
    {
        public Dictionary<int, int> Map { get; set; }
        public Stack<int> Stack { get; set; }
        public Stack<int> StackValue { get; set; }
        
        public List<MyPair> s { get; set; }

        int key;
        int value;

        public FreqStack()
        {
            Map = new Dictionary<int, int>();
            Stack = new Stack<int>();
            s = new List<MyPair>();
            key = value = 0;
        }

        public void Push(int x)
        {
            s.Add(new MyPair(x, true));

            if (!Map.ContainsKey(x)) Map[x] = 1;
            else Map[x]++;

            if (Map[x] >= value)
            {
                value = Map[x];
                key = x;
            }
        }

        public int Pop()
        {
            Map[key] = value - 1;
            int ret = key;

            bool isEmpty = true;
            for (int i = s.Count - 1; i >= 0; i--)
            {
                if (s[i].Item2) isEmpty = false;
                if (s[i].Item1 == key && s[i].Item2 == true) { s.RemoveAt(i); break; }
            }

            if (isEmpty) return ret;
            /////////////////

            int max = Map.Max(x => x.Value);

            for (int i = s.Count - 1; i >= 0; i--)
            {
                if (Map[s[i].Item1] == max && s[i].Item2 == true)
                {
                    key = s[i].Item1;
                    value = Map[s[i].Item1];
                    break;
                }
            }

            return ret;
        }
    }
}
