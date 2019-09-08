using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class FindMaximumAverageSubTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public List<TreeNode> child;
            public TreeNode(int x) { val = x; }
        }

        public double MaximumAverageSubtree(TreeNode root)
        {
            return Recursion(root)[2];
        }

        private double[] Recursion(TreeNode root)
        {
            if (root == null)
                return new double[] { 0, 0, 0 }; // sum, node count, average

            double[] left = Recursion(root.left);

            double[] right = Recursion(root.right);

            double child = Math.Max(left[2], right[2]);

            var sum = root.val + left[0] + right[0];

            var count = 1 + left[1] + right[1];

            double max = Math.Max(sum / count, child);

            return new double[] { sum, count, max };
        }

        public double MaximumAverageSubtreeWithMultipleChild(TreeNode root)
        {
            return RecursionMultipleChild(root)[2];
        }

        public double[] RecursionMultipleChild(TreeNode root)
        {
            if (root == null)
                return new double[] { 0, 0, 0 }; // sum, node count, average

            double sum = 0;
            double count = 0;
            double[] current = new double[] { };

            foreach (var children in root.child)
            {
                current = RecursionMultipleChild(children);
                sum += current[0];
                count = current[1];
            }

            double avg = sum / count;

            if(count > 1 && avg > current[2])
            {
                
            }

            return new double[] { sum, count, 0 };
        }
    }
}
