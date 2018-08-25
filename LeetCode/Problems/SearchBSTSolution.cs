using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class SearchBSTSolution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            else if (val == root.val) return root;
            else
            {
                if (val < root.val) return SearchBST(root.left, val);
                else return SearchBST(root.right, val);
            }
        }
    }
}
