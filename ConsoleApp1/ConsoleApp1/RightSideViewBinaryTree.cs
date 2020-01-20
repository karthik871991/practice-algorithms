using System.Collections.Generic;

namespace AlgoPractice
{
    public class RightSideViewBinaryTree
    {
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null)
                return new List<int>();

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            var result = new List<int>();

            while (q.Count != 0)
            {
                var size = q.Count;

                var list = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    var node = q.Dequeue();

                    list.Add(node.val);

                    if (node.left != null)
                        q.Enqueue(node.left);

                    if (node.right != null)
                        q.Enqueue(node.right);
                }

                result.Add(list[list.Count - 1]);
            }

            return result;
        }
        public class TreeNode
        {
            public TreeNode left { get; set; }
            public TreeNode right { get; set; }
            public int val { get; set; }
        }

    }
}
