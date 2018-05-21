using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class DailyTemperaturesSolution
    {
        public DailyTemperaturesSolution()
        {
            DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
        }

        //accepted
        public int[] DailyTemperatures(int[] temperatures)
        {
            var hash = new Dictionary<int, int>();
            var stack = new Stack<int>();
            var indexStack = new Stack<int>();


            int index = 0;
            foreach (var num in temperatures)
            {
                hash[index] = 0;
                while (stack.Count != 0 && stack.Peek() < num)
                {
                    int top = stack.Pop();
                    int topIndex = indexStack.Pop();

                    hash[topIndex] = index - topIndex;
                }

                stack.Push(num);
                indexStack.Push(index);
                index++;
            }

            return hash.OrderBy(x => x.Key).Select(x => x.Value).ToArray();
        }
    }
}
