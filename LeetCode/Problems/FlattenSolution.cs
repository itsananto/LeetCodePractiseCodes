using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class FlattenSolution
    {
        public FlattenSolution(TreeNode root)
        {
            Flatten(root);
        }

        public void Flatten(TreeNode root)
        {
            if (root == null) return;
            FlattenTree(root);
        }

        public TreeNode FlattenTree(TreeNode root)
        {
            var left = root.left;
            var right = root.right;

            if (left == null && right == null) return root;

            if (left != null)
            {
                root.right = left;
                root.left = null;

                var last = root.right == null ? root : FlattenTree(root.right);
                if (last != right) last.right = right;

                if (right == null) return last;
                if (last.right == null) return last;
                return FlattenTree(last.right);
            }
            else
            {
                return FlattenTree(root.right);
            }
        }
    }
}
