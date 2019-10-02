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
            if (root == null)
                return true;

            if (root.left == null && root.right == null)
                return true;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                var size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    var cur = q.Dequeue();
                    q.Enqueue(cur.left);
                    q.Enqueue(cur.right);
                }

                if (size != 2 * q.Count)
                    return false;
            }

            bool f = false;

            while (q.Count != 0)
            {
                if (!f)
                    f = q.Dequeue() == null;
                else
                {

                }
            }

            return true;
        }
    }
}
