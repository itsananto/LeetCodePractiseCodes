using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class InsertIntoBSTSolution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if(root == null)
            {
                root = new TreeNode(val);
            }
            else if (root.val >= val)
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(val);
                }
                else
                {
                    InsertIntoBST(root.left, val);
                }
            }
            else
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(val);
                }
                else
                {
                    InsertIntoBST(root.right, val);
                }
            }

            return root;
        }
    }
}
