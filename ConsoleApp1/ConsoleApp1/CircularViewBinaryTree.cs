using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class CircularViewBinaryTree
    {
        public IList<int> BoundaryOfBinaryTree(TreeNode root)
        {
            var left = new List<int>();
            var bottom = new List<int>();
            var right = new List<int>();
            var head = root;
            var q = new Queue<TreeNode>();
            q.Enqueue(head);

            while (q.Any())
            {
                var size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    var node = q.Dequeue();
                    if (size == 1)
                    {
                        right.Add(node.val);
                    }
                    else
                    {
                        if (i == 0)
                            left.Add(node.val);
                        if (i == size - 1)
                            right.Add(node.val);
                    }
                    if (node.left == null && node.right == null)
                        bottom.Add(node.val);

                    if (node.left != null)
                        q.Enqueue(node.left);

                    if (node.right != null)
                        q.Enqueue(node.right);

                }
            }

            Console.WriteLine(left.Count);
            foreach (var i in left)
            {
                Console.WriteLine(i);
            }
            var result = new List<int>();

            result.Add(root.val);
            for (int i = 0; i < left.Count - 1; i++)
            {
                Console.WriteLine(left[i]);
                result.Add(left[i]);
            }
            for (int i = 0; i < bottom.Count; i++)
            {
                result.Add(bottom[i]);
            }
            right.Reverse();
            for (int i = 1; i < right.Count - 1; i++)
            {
                result.Add(right[i]);
            }

            return result;
        }
        public class TreeNode
        {
            public int val { get; set; }
            public TreeNode left { get; set; }
            public TreeNode right { get; set; }
            //public TreeNode(int x) { val = x; }
        }
    }
    
}
