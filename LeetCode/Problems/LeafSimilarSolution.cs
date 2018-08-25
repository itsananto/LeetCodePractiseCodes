using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class LeafSimilarSolution
    {
        public LeafSimilarSolution()
        {
            var root = new TreeNode(new object[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 });
            LeafSimilar(root, root);
        }

        public List<int> GetLeafValueSequence(TreeNode root)
        {
            if(root.left == null && root.right == null)
            {
                return new List<int>(new int[] { root.val });
            }
            else
            {
                var left = root.left != null ? GetLeafValueSequence(root.left): new List<int>();
                var right = root.right != null ? GetLeafValueSequence(root.right) : new List<int>();

                left.AddRange(right);

                return left;
            }
        }

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var first = GetLeafValueSequence(root1);
            var second = GetLeafValueSequence(root2);

            if (first.Count != second.Count) return false;

            for (int i = 0; i < first.Count; i++)
            {
                if (first[i] != second[i]) return false;
            }

            return true;
        }
    }
}
