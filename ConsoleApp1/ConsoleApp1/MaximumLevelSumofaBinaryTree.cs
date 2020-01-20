using System.Collections.Generic;

namespace AlgoPractice
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
    }
    public class MaximumLevelSumofaBinaryTree
    {
        public int MaxLevelSum(TreeNode root)
        {
            if (root == null)
                return 0;
            
            int level = 1;
            int maxLevel = 1;
            int currentSum = int.MinValue;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                var size = q.Count;

                var sum = 0;

                for (int i = 0; i < size; i++)
                {
                    var node = q.Dequeue();

                    sum += node.val;

                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }

                if (sum > currentSum)
                {
                    currentSum = sum;
                    maxLevel = level;
                }

                level++;
            }

            return maxLevel;
        }

        //public class TreeNode
        //{
        //    public TreeNode left { get; set; }
        //    public TreeNode right { get; set; }
        //    public int val { get; set; }
        //}
    }
}
