using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class OptimalDivisionSolution
    {
        public OptimalDivisionSolution()
        {
            //OptimalDivision(new int[] { 1000, 100, 10, 2 });
            OptimalDivision(new int[] { 2, 2, 2, 2 });
        }

        Dictionary<List<List<int>>, Dictionary<string, float>> global = new Dictionary<List<List<int>>, Dictionary<string, float>>();

        public Dictionary<string, float> OptimalDivision(List<List<int>> parts)
        {
            if (global.ContainsKey(parts)) return global[parts];
            Dictionary<string, float> ret = new Dictionary<string, float>();

            Dictionary<string, float>[] keyValuePair = new Dictionary<string, float>[2];

            int index = 0;
            foreach (var list in parts)
            {
                keyValuePair[index] = new Dictionary<string, float>();
                if (list.Count == 1) keyValuePair[index].Add(list[0].ToString(), list[0]);
                else
                {
                    for (int i = 1; i < list.Count; i++)
                    {
                        List<List<int>> param = new List<List<int>>();
                        param.Add(list.Take(i).ToList());
                        param.Add(list.Skip(i).ToList());
                        var output = OptimalDivision(param);

                        foreach (var item in output)
                        {
                            if (!keyValuePair[index].ContainsKey(item.Key))
                            {
                                keyValuePair[index].Add(item.Key, item.Value);
                            }
                        }
                    }
                }
                index++;
            }

            foreach (var pair in keyValuePair[0])
            {
                foreach (var pair1 in keyValuePair[1])
                {
                    int count = parts[1].Count;
                    if (count <= 1)
                        ret.Add(pair.Key + "/" + pair1.Key + "", pair.Value / pair1.Value);
                    else
                        ret.Add(pair.Key + "/(" + pair1.Key + ")", pair.Value / pair1.Value);
                }
            }
            global[parts] = ret;
            return ret;
        }

        //accepted
        public string OptimalDivision(int[] nums)
        {
            if (nums.Length == 3)
            {
                if (((float)nums[0] / (float)nums[1]) / (float)nums[2] > (float)nums[0] / ((float)nums[1] / (float)nums[2])) return nums[0] + "/" + nums[1] + "/" + nums[2];
                else return nums[0] + "/(" + nums[1] + "/" + nums[2] + ")";
            }
            else if (nums.Length == 2)
            {
                return nums[0] + "/" + nums[1];
            }
            else if (nums.Length == 1)
            {
                return nums[0].ToString();
            }
            else
            {
                var ret = new Dictionary<string, float>();
                for (int i = 1; i < nums.Length; i++)
                {
                    List<List<int>> param = new List<List<int>>();
                    param.Add(nums.Take(i).ToList());
                    param.Add(nums.Skip(i).ToList());

                    foreach (var item in OptimalDivision(param))
                    {
                        if (!ret.ContainsKey(item.Key))
                        {
                            ret.Add(item.Key, item.Value);
                        }
                    }
                }

                string output = ret.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

                return output;
            }
        }
    }
}
