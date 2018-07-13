using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class PyramidTransitionSolution
    {
        public PyramidTransitionSolution()
        {
            PyramidTransition("XXYX", new string[] { "XXX", "XXY", "XYX", "XYY", "YXZ" });
            //PyramidTransition("XYZ", new string[] { "XYD", "YZE" });
        }

        Dictionary<string, string> dict = new Dictionary<string, string>();

        public bool CanConstructPyramid(string bottom)
        {
            if (bottom.Length == 1) return true;

            IList<string> newBottomList = new List<string>();
            IList<string> tempBottomList;

            for (int i = 0; i < bottom.Length - 1; i++)
            {
                string triangleBase = bottom.Substring(i, 2);

                tempBottomList = new List<string>(newBottomList);
                newBottomList.Clear();

                if (dict.ContainsKey(triangleBase))
                {
                    if (tempBottomList.Count == 0)
                    {
                        foreach (var ch in dict[triangleBase])
                        {
                            string str = ch.ToString();
                            newBottomList.Add(str);
                        }
                    }
                    else
                    {
                        foreach (var item in tempBottomList)
                        {
                            foreach (var ch in dict[triangleBase])
                            {
                                string str = item + ch;
                                newBottomList.Add(str);
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }

            }

            bool flag = false;
            foreach (var b in newBottomList.Distinct())
            {
                flag = flag || CanConstructPyramid(b);
                if (flag) break;
            }

            return flag;
        }

        public bool PyramidTransition(string bottom, IList<string> allowed)
        {
            dict.Clear();

            foreach (var triangle in allowed)
            {
                string first = triangle.Substring(0, 2);
                string second = triangle.Substring(0, 1) + triangle.Substring(2, 1);
                string third = triangle.Substring(1, 2);

                if (dict.ContainsKey(first))
                {
                    dict[first] = dict[first] + triangle.Substring(2, 1);
                }
                else
                {
                    dict[first] = triangle.Substring(2, 1);
                }
            }

            return CanConstructPyramid(bottom);
        }
    }
}
