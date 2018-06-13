using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helpers
{
    class CodeSnippet
    {
        HashSet<string> globalList = new HashSet<string>();
        List<List<string>> Combination(List<string> temp)
        {
            if (temp.Count == 2)
            {
                var tempList = new List<string>() { temp[0], temp[1] };
                tempList = tempList.OrderBy(x => x).ToList();

                globalList.Add(tempList[0] + "_" + tempList[1]);

                return new List<List<string>>() { tempList };

            }
            else
            {
                globalList.Add(String.Join("_", temp));
                List<List<string>> ret = new List<List<string>>();
                for (int i = 0; i < temp.Count; i++)
                {
                    var tempList = temp.Where((v, ind) => ind != i).ToList();

                    if (!globalList.Contains(string.Join("_", tempList)))
                    {
                        var retList = Combination(tempList);

                        foreach (var item in retList)
                        {
                            item.Add(temp[i]);
                            var ordered = item.OrderBy(x => x).ToList();
                            ret.Add(ordered);
                            globalList.Add(String.Join("_", ordered));
                        }
                    }
                }


                return ret;
            }
        }
    }
}
