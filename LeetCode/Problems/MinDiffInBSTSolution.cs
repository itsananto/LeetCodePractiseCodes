using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class MinDiffInBSTSolution
    {
        public MinDiffInBSTSolution()
        {
            MinDiffInBST(new TreeNode(new object[] { 4, 2, 6, 1, 3, null, null }));
        }
        
        public void InOrder(TreeNode root, List<int> list)
        {
            if (root == null) return;

            InOrder(root.left, list);
            list.Add(root.val);
            InOrder(root.right,list);
        }

        public int MinDiffInBST(TreeNode root)
        {
            int min = int.MaxValue;
            var list = new List<int>();
            InOrder(root, list);

            for (int i = 1; i < list.Count; i++)
            {
                min = Math.Min(min, list[i] - list[i - 1]);
            }

            return min;
        }
    }
}
