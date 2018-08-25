using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class NumRescueBoatsSolution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            var d = new Dictionary<int, int>();
            foreach (var item in people)
            {
                if (d.ContainsKey(item))
                {
                    d[item]++;
                }
                else
                {
                    d[item] = 1;
                }
            }

            int turns = 0;
            for (int i = 0; i < people.Length; i++)
            {
                if (d.ContainsKey(people[i]) && d[people[i]]>0)
                {
                    turns++;
                    int tempLimit = limit - people[i];
                    d[people[i]]--;

                    while (tempLimit > 0)
                    {
                        if (d.ContainsKey(tempLimit) && d[tempLimit] > 0)
                        {
                            d[tempLimit]--;
                            break;
                        }
                        tempLimit--;
                    }
                }
            }

            return turns;
        }

        public int NumRescueBoats_TLE(int[] people, int limit)
        {
            int turns = 0;
            people = people.OrderByDescending(x => x).ToArray();
            bool[] visited = new bool[people.Length];

            for (int i = 0; i < people.Length; i++)
            {
                if (!visited[i])
                {
                    turns++;
                    int tempLimit = limit - people[i];
                    visited[i] = true;

                    for (int j = i + 1; j < people.Length; j++)
                    {
                        if (tempLimit >= people[j] && !visited[j])
                        {
                            tempLimit -= people[j];
                            visited[j] = true;
                            break;
                        }
                    }
                }
            }

            return turns;
        }
    }
}
