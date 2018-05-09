using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructures
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public TreeNode(object[] input)
        {
            if (input.Length > 0)
            {
                Queue<TreeNode> q = new Queue<TreeNode>();

                this.val = (int)input[0];
                q.Enqueue(this);

                for (int i = 1; i < input.Length; i += 2)
                {
                    TreeNode current = q.Dequeue();
                    if (input[i] == null)
                    {

                    }
                    else
                    {
                        current.left = new TreeNode((int)input[i]);
                        q.Enqueue(current.left);
                    }

                    if (i + 1 != input.Length)
                    {
                        if (input[i + 1] == null)
                        {

                        }
                        else
                        {
                            current.right = new TreeNode((int)input[i + 1]);
                            q.Enqueue(current.right);
                        }
                    }
                }
            }
        }
    }
}
