using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class PruneTreeSolution
    {
        public PruneTreeSolution()
        {
            //Tested Test Cases:
            //[1, null, 0, 0, 1]
            //[1]
            //[0]
            //[1, 0, 1, 0, 0, 0, 1]
            //[1, 1, 0, 1, 1, 0, 1, 0]

            TreeNode root = new TreeNode(new object[] { 1, null, 0, 0, 1 });
            PruneTree(root);
        }

        public bool Prune(ref TreeNode root)
        {
            if (root == null) return false;
            else
            {
                bool leftTree = Prune(ref root.left);
                bool rightTree = Prune(ref root.right);

                if (!leftTree) root.left = null;
                if (!rightTree) root.right = null;
                return root.val != 0 || leftTree || rightTree;
            }
        }

        //accepted
        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null) return null;
            Prune(ref root);

            if (root.left == null && root.right == null && root.val == 0) return null;
            else return root;
        }
    }
}
