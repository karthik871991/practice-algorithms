using System.Collections.Generic;

namespace AlgoPractice
{
    public class CheckCompletenessofaBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool IsCompleteTree(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while(q.Peek() != null)
            {
                var curr = q.Dequeue();
                q.Enqueue(curr.left);
                q.Enqueue(curr.right);
            }

            while(q.Count != 0 && q.Peek() == null)
            {
                q.Dequeue();
            }

            return q.Count == 0;
        }
    }
}
