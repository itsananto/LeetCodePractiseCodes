using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class PostorderSolution
    {
        public IList<int> Postorder(Node root)
        {
            if(root == null)
            {
                return new List<int>();
            }
            else
            {
                List<int> ret = new List<int>();
                foreach (var child in root.children)
                {
                    ret.AddRange(Postorder(child));
                }

                ret.Add(root.val);

                return ret;
            }
        }
    }
}
