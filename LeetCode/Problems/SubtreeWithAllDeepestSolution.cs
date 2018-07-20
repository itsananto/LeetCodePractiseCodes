using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class SubtreeWithAllDeepestSolution
    {
        public SubtreeWithAllDeepestSolution()
        {
            //TreeNode root = new TreeNode(new object[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });
            TreeNode root = new TreeNode(new object[] { 3, 4 });
            SubtreeWithAllDeepest(root);
        }

        TreeNode ret;
        Dictionary<TreeNode, int> d;

        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            else
            {
                int depth = 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
                d.Add(root, depth);

                return depth;
            }
        }

        public void AllDeepest(TreeNode root, int depth, int currDepth)
        {
            if (depth == currDepth) ret = root;
            else
            {
                bool left = root.left == null ? false : (depth == currDepth + d[root.left]);
                bool right = root.right == null ? false : (depth == currDepth + d[root.right]);

                if (left && right) ret = root;
                else if (left && !right && root.left != null) AllDeepest(root.left, depth, currDepth + 1);
                else if (!left && right && root.right != null) AllDeepest(root.right, depth, currDepth + 1);
            }
        }

        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            d = new Dictionary<TreeNode, int>();
            int depth = MaxDepth(root);
            AllDeepest(root, depth, 1);
            return ret;
        }
    }
}
